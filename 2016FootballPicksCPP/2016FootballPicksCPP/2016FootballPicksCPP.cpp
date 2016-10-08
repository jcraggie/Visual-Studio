// 2016FootballPicksCPP.cpp : Defines the entry point for the console application.
//
// Files
//		Load master list
//		Load update file
//		Save master list
// Statistics
//		By Year
//		By Sheet
//		All Time
//		By CFB or NFL
// Edit
//		Create a game
//		Edit a game
//		Delete a game

#include "stdafx.h"
#include "FootballPicks.h"
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <algorithm>
#include <iomanip>
#include <sstream>

using namespace std;

void RemoveRanking(string& word)
{
	string temp=" ";
	int start = 0;
	int size = 0;
	int j = 0;
	if (word[0] != '(')
		return;
	size = word.size();
	for (int i = 0; i < size; ++i)
	{
		if (word[i] == ')')
		{
			start = i + 2;
			break;
		}
	}
	word.erase(0, start);
	//for (int i = start; i < size; ++i)
	//{
	//	temp[j] = word[i];
	//	j += 1;
	//}

	//word = temp;
	return;
}

void ReadFile(vector<CGame>& game, string fileName)
{
	vector<CGame>::iterator iterG;
	string word;
	vector<string> line;
	string str;
	vector<string>::iterator iterC;
	string gameLine;
	int wordCount;
	int amt;
	float flt;
	stringstream ss;

	ifstream myFile2(fileName);
	//ifstream myFile2 ("2016gameData1.txt");
	//while (myFile2)
	while (getline(myFile2,str))
	{
		//getline(myFile2, str);
		line.push_back(str);

		//cout << str << endl;
	}

	for (iterC = line.begin(); iterC != line.end(); ++iterC)
	{
		CGame* newGame = new CGame;
		gameLine = *iterC; // 1 word
		wordCount = 0;
		
		//cout << "game size is: " << game.size() << endl;
		//cout << "Word is: " << w << endl;
		for (int i = 0; i <= gameLine.size(); ++i) // loop through entire game line
		{
			//if (gameLine[0] == '\t' || gameLine[1] == '\t')
			//	break;
			ss.str("");
			if (gameLine[i] != '\t' && i != gameLine.size()) // if the char is not a tab
			{
				word.push_back(gameLine[i]); // push the char found to word. once encounter tab, word is done.
			}
			else
			{
				wordCount += 1;
				//cout << setw(20) << word;

				switch (wordCount)
				{
				case 1:
					newGame->SetTime(word);
					break;
				case 2:
					newGame->SetAwayTeam(word);
					break;
				case 3:
					newGame->SetHomeTeam(word);
					break;
				case 4:
					RemoveRanking(word);
					newGame->SetUDTeam(word);
					break;
				case 5:
					if (word == "NL" || word == "NO LINE")
					{
						word = "NL";
						flt = 0.0;
					}
					else if (word == "PK")
					{
						word = "PK";
						flt = 0.0;
					}
					else
					{
						flt = std::stof(word);
						flt = abs(flt);
						//word = to_string(flt);
						ss << fixed << setprecision(1) << flt;
						word = ss.str();
					}
					newGame->SetUDPts(flt);
					newGame->SetUDline(word);

					break;
				case 6:
					newGame->SetAwayRank(word);
					break;
				case 7:
					newGame->SetHomeRank(word);
					break;
				case 8:
					newGame->SetUDrank(word);
					break;
				case 9:
					newGame->SetAwayConf(word);
					break;
				case 10:
					newGame->SetHomeConf(word);
					break;
				case 11:
					newGame->SetDate(word);
					break;
				case 12:
					newGame->SetGameType(word);
					break;
				case 13:
					newGame->SetSeason(word);
					break;
				case 14:
					newGame->SetSheet(word);
					break;
				case 15:
					amt = std::stoi(word);
					newGame->SetGameNum(amt);
					break;
				case 16:
					newGame->SetGameID(word);
					break;
				case 17:
					amt = std::stoi(word);
					newGame->SetAwayScore(amt);
					break;
				case 18:
					amt = std::stoi(word);
					newGame->SetHomeScore(amt);
					break;
				case 19:
					RemoveRanking(word);
					newGame->SetJMCgamePick(word);
					break;
				case 20:
					RemoveRanking(word);
					newGame->SetJCRgamePick(word);
					break;
				case 21:
					RemoveRanking(word);
					newGame->SetJMCspreadPick(word);
					break;
				case 22:
					RemoveRanking(word);
					newGame->SetJCRspreadPick(word);
					break;
				case 23:
					RemoveRanking(word);
					newGame->SetTeamGameWinner(word);
					break;
				case 24:
					RemoveRanking(word);
					newGame->SetTeamSpreadWinner(word);
					break;
				case 25:
					amt = std::stoi(word);
					newGame->SetJMCwinGame(amt);
					break;
				case 26:
					amt = std::stoi(word);
					newGame->SetJCRwinGame(amt);
					break;
				case 27:
					amt = std::stoi(word);
					newGame->SetJMCwinSpread(amt);
					break;
				case 28:
					amt = std::stoi(word);
					newGame->SetJCRwinSpread(amt);
					break;

				}
				word = "";
			}



		}
		game.push_back(*newGame);
		//cout << setw(15) << word;
		word = "";
		//cout << endl;


	}

}

void Statistics(vector<CGame> game)
{
	vector<CGame>::iterator iterG;

	for (iterG = game.begin(); iterG != game.end(); ++iterG)
	{

	}
}

void PrintTopHorizGrid()
{
	char horizBar = (char)196;
	char crossBar = (char)197;
	char teeBar = (char)194;
	char revTeeBar = (char)193;
	char leftTopCorner = (char)218;
	char leftBotCorner = (char)192;
	char rightTopCorner = (char)191;
	char rightBotCorner = (char)217;
	char leftHorizTee = (char)195;
	char rightHorizTee = (char)180;

	cout << leftTopCorner;
	for (int i = 0; i < 11; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 35; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 8; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 22; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 7; ++i)
		cout << horizBar;
	cout << teeBar;
	for (int i = 0; i < 12; ++i)
		cout << horizBar;
	cout << rightTopCorner;
	cout << endl;
}


void PrintInteriorHorizGrid()
{
	char horizBar = (char)196;
	char crossBar = (char)197;
	char teeBar = (char)194;
	char revTeeBar = (char)193;
	char leftTopCorner = (char)218;
	char leftBotCorner = (char)192;
	char rightTopCorner = (char)191;
	char rightBotCorner = (char)217;
	char leftHorizTee = (char)195;
	char rightHorizTee = (char)180;

	cout << leftHorizTee;
	for (int i = 0; i < 11; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 35; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 8; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 22; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 7; ++i)
		cout << horizBar;
	cout << crossBar;
	for (int i = 0; i < 12; ++i)
		cout << horizBar;
	cout << rightHorizTee;
	cout << endl;
}

void PrintBotHorizGrid()
{
	char horizBar = (char)196;
	char crossBar = (char)197;
	char teeBar = (char)194;
	char revTeeBar = (char)193;
	char leftTopCorner = (char)218;
	char leftBotCorner = (char)192;
	char rightTopCorner = (char)191;
	char rightBotCorner = (char)217;
	char leftHorizTee = (char)195;
	char rightHorizTee = (char)180;

	cout << leftBotCorner;
	for (int i = 0; i < 11; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 35; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 8; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 22; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 24; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 7; ++i)
		cout << horizBar;
	cout << revTeeBar;
	for (int i = 0; i < 12; ++i)
		cout << horizBar;
	cout << rightBotCorner;
	cout << endl;
}


void PrintGames(vector<CGame> game)
{
	vector<CGame>::iterator iterG;
	std::string awayRankAndTeam;
	std::string homeRankAndTeam;
	char JMCwinG{ ' ' }, JCRwinG{ ' ' }, JMCwinS{ ' ' }, JCRwinS{ ' ' };
	string awayLineChars{ ' ' }, homeLineChars{ ' ' };
	string vertBar = " " + string(1,(char) 179) + " "; // to convert char to string, use string(size_t,char)
	string sVertBar = string(1, (char)179);

	cout << endl << endl << endl << "Looping through CGame class variable game: " << endl << endl;

	PrintTopHorizGrid();

	for (iterG = game.begin(); iterG != game.end(); ++iterG)
	{
		JMCwinG = ' ';
		JCRwinG = ' ';
		JMCwinS = ' ';
		JCRwinS = ' ';
		awayLineChars = ' ';
		homeLineChars = ' ';


		


		if (iterG->GetAwayRank() != "" && iterG->GetAwayRank() != "0")
			awayRankAndTeam = "#" + iterG->GetAwayRank() + " " + iterG->GetAwayTeam();
		else
			awayRankAndTeam = " " + iterG->GetAwayTeam();
		if (iterG->GetHomeRank() != "" && iterG->GetHomeRank() != "0")
			homeRankAndTeam = "#" + iterG->GetHomeRank() + " " + iterG->GetHomeTeam();
		else
			homeRankAndTeam = " " + iterG->GetHomeTeam();
		if (iterG->GetJMCwinGame() == 1)
			JMCwinG = '*';
		if (iterG->GetJCRwinGame() == 1)
			JCRwinG = '*';
		if (iterG->GetJMCwinSpread() == 1)
			JMCwinS = '*';
		if (iterG->GetJCRwinSpread() == 1)
			JCRwinS = '*';
		if (iterG->GetUDTeam() == iterG->GetAwayTeam())
			if (iterG->GetUDline() == "NL")
				awayLineChars = iterG->GetUDline();
			else
				awayLineChars = "+" + iterG->GetUDline();
		else
			awayLineChars = " ";
		if (iterG->GetUDTeam() == iterG->GetHomeTeam())
			if (iterG->GetUDline() == "NL")
				homeLineChars = iterG->GetUDline();
			else
				homeLineChars = "+" + iterG->GetUDline();
		else
			homeLineChars = " ";

		cout << sVertBar << setw(10) << iterG->GetTime() << vertBar;
		cout << setw(7) << iterG->GetAwayConf();
		cout << setw(20) << awayRankAndTeam;
		cout << setw(6) << awayLineChars << vertBar;
		cout << setw(6) << iterG->GetAwayScore() << vertBar;
		cout << setw(20) << iterG->GetTeamGameWinner() << vertBar;
		cout << setw(20) << iterG->GetJMCgamePick() << " " << JMCwinG << vertBar;
		cout << setw(20) << iterG->GetJCRgamePick() << " " << JCRwinG << vertBar;
		cout << setw(20) << iterG->GetJMCspreadPick() << " " << JMCwinS << vertBar;
		cout << setw(20) << iterG->GetJCRspreadPick() << " " << JCRwinS << vertBar;
		cout << setw(5) << iterG->GetSeason() << vertBar;
		cout << setw(10) << iterG->GetGameNum() << vertBar;
		cout << endl;

		cout << sVertBar << setw(10) << iterG->GetDate() << vertBar;
		cout << setw(7) << iterG->GetHomeConf();
		cout << setw(20) << homeRankAndTeam;
		cout << setw(6) << homeLineChars << vertBar;
		cout << setw(6) << iterG->GetHomeScore() << vertBar;
		cout << setw(20) << iterG->GetTeamSpreadWinner() << vertBar;
		cout << setw(25) << vertBar << setw(25) << vertBar << setw(25) << vertBar << setw(25) << vertBar;
		cout << setw(5) << iterG->GetSheet() << vertBar;
		cout << setw(10) << iterG->GetGameID() << vertBar;
		cout << endl;

		if (iterG + 1 != game.end())
			PrintInteriorHorizGrid();
		else
			PrintBotHorizGrid();
	}
}

void WriteFile(vector<CGame>& game, string fileName)
{
	std::ofstream write(fileName);
	vector<CGame>::iterator iterG;

	for (iterG = game.begin(); iterG != game.end(); ++iterG)
	{
		write << iterG->GetTime() << '\t';
		write << iterG->GetAwayTeam() << '\t';
		write << iterG->GetHomeTeam() << '\t';
		write << iterG->GetUDTeam() << '\t';
		write << iterG->GetUDline() << '\t';
		//write << iterG->GetUDPts() << '\t';
		write << iterG->GetAwayRank() << '\t';
		write << iterG->GetHomeRank() << '\t';
		write << iterG->GetUDrank() << '\t';
		write << iterG->GetAwayConf() << '\t';
		write << iterG->GetHomeConf() << '\t';
		write << iterG->GetDate() << '\t';
		write << iterG->GetGameType() << '\t';
		write << iterG->GetSeason() << '\t';
		write << iterG->GetSheet() << '\t';
		write << iterG->GetGameNum() << '\t';
		write << iterG->GetGameID() << '\t';
		write << iterG->GetAwayScore() << '\t';
		write << iterG->GetHomeScore() << '\t';
		write << iterG->GetJMCgamePick() << '\t';
		write << iterG->GetJCRgamePick() << '\t';
		write << iterG->GetJMCspreadPick() << '\t';
		write << iterG->GetJCRspreadPick() << '\t';
		write << iterG->GetTeamGameWinner() << '\t';
		write << iterG->GetTeamSpreadWinner() << '\t';
		write << iterG->GetJMCwinGame() << '\t';
		write << iterG->GetJCRwinGame() << '\t';
		write << iterG->GetJMCwinSpread() << '\t';
		write << iterG->GetJCRwinSpread();
		write << '\n';
	}
	write.close();
	return;
}

void MainMenu()
{
	system("cls"); // clear output screen
	cout << "R - Read Master File" << endl;
	cout << "W - Write Master File" << endl;
	cout << "I - Import New Data into Master File" << endl;
	cout << "F - Change File Names" << endl;
	cout << "P - Print Data to Screen" << endl;
	cout << "X - Exit Program" << endl;
}

void GetStats(vector<CGame>& game)
{
	vector<CGame>::iterator iterG;

	//CGame::s_JMCgamesWon = 0;
	//CGame::s_JCRgamesWon = 0;
	//CGame::s_JMCspreadWon = 0;
	//CGame::s_JCRspreadWon = 0;
	//CGame::s_NumGamesPlayed = 0;
	//CGame::s_NumSpreadPlayed = 0;
	int sht = 0;
	for (iterG = game.begin(); iterG != game.end(); ++iterG)
	{
		sht = stoi(iterG->GetSheet());

		if (iterG->GetUDline() != "PK" && iterG->GetUDline() != "NL")
		{
			CGame::s_NumSpreadPlayed[sht] += 1;
		}
		CGame::s_NumGamesPlayed[sht] += 1;
		if (iterG->GetJMCwinGame())
			CGame::s_JMCgamesWon[sht] += 1;
		if (iterG->GetJCRwinGame())
			CGame::s_JCRgamesWon[sht] += 1;
		if (iterG->GetJMCwinSpread())
			CGame::s_JMCspreadWon[sht] += 1;
		if (iterG->GetJCRwinSpread())
			CGame::s_JCRspreadWon[sht] += 1;
	}
}

void PrintStats(vector<CGame>& game)
{
	int sht = 1;

	cout << endl << endl;
	cout << setw(42) << "Correct Game Winners" << setw(38) << "Correct Spread Winners" << endl;
	cout << setw(30) << "JMC" << setw(7) << "JCR" << setw(30) << "JMC" << setw(7) << "JCR" << endl;
	for (sht = 1; sht < 3; ++sht)
	{
		cout << "Sheet: " << sht;
		cout << setw(22) << CGame::s_JMCgamesWon[sht];
		cout << setw(7) << CGame::s_JCRgamesWon[sht];
		cout << setw(30) << CGame::s_JMCspreadWon[sht];
		cout << setw(7) << CGame::s_JCRspreadWon[sht];
		cout << endl;
		//cout << "Number of Games Picked: " << CGame::s_NumGamesPlayed[sht] << endl;
		//cout << "Number of Spreads Picked: " << CGame::s_NumSpreadPlayed[sht] << endl;
	}
}

int main()
{
	string w;
	vector<string> gameInfo;
	vector<CGame> game;
	vector<CGame>::iterator iterG;
	string fileName, readFile, writeFile;

	// THOUGHTS
	// maybe have import files for each tab. that way you can recreate master file if needed or just read in 1 tab's data.


	//fileName = "2016 ExportText.txt";
	//fileName = "2016 Football Picks Master Data.txt";
	readFile = "2016 sheet 1.txt";
	ReadFile(game, readFile);
	ReadFile(game, "2016 sheet 2.txt");
	GetStats(game);
	//fileName = "2016 Football Picks Import.txt";
	//readFile = "2016 TESTimportNew.txt";
	//ReadFile(game, readFile);
	//ReadFile(game, fileName);
	PrintGames(game);
	PrintStats(game);
	//writeFile = "2016 TESTwriteFinal.txt";
	//WriteFile(game, writeFile);

    return 0;
}

