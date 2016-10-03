// 2016FootballPicksCPP.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "FootballPicks.h"
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <algorithm>
#include <iomanip>

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

	ifstream myFile2(fileName);
	//ifstream myFile2 ("2016gameData1.txt");
	while (myFile2)
	{
		getline(myFile2, str);
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
		for (int i = 0; i < gameLine.size(); ++i) // loop through entire game line
		{
			if (gameLine[0] == '\t')
				break;
			if (gameLine[i] != '\t') // if the char is not a tab
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
						amt = 0;
					}
					else
					{
						amt = std::stoi(word);
						amt = abs(amt);
						word = to_string(amt);
					}
					newGame->SetUDPts(amt);
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
					amt = std::stoi(word);
					newGame->SetAwayScore(amt);
					break;
				case 13:
					amt = std::stoi(word);
					newGame->SetHomeScore(amt);
					break;
				case 14:
					RemoveRanking(word);
					newGame->SetJMCgamePick(word);
					break;
				case 15:
					RemoveRanking(word);
					newGame->SetJCRgamePick(word);
					break;
				case 16:
					RemoveRanking(word);
					newGame->SetJMCspreadPick(word);
					break;
				case 17:
					RemoveRanking(word);
					newGame->SetJCRspreadPick(word);
					break;
				case 18:
					RemoveRanking(word);
					newGame->SetTeamGameWinner(word);
					break;
				case 19:
					RemoveRanking(word);
					newGame->SetTeamSpreadWinner(word);
					break;
				case 20:
					amt = std::stoi(word);
					newGame->SetJMCwinGame(amt);
					break;
				case 21:
					amt = std::stoi(word);
					newGame->SetJCRwinGame(amt);
					break;
				case 22:
					amt = std::stoi(word);
					newGame->SetJMCwinSpread(amt);
					break;
				case 23:
					amt = std::stoi(word);
					newGame->SetJCRwinSpread(amt);
					break;
				case 24:
					newGame->SetGameType(word);
					break;
				case 25:
					newGame->SetSeason(word);
					break;
				case 26:
					newGame->SetSeason(word);
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

void PrintGames(vector<CGame> game)
{
	vector<CGame>::iterator iterG;
	std::string awayRankAndTeam;
	std::string homeRankAndTeam;
	char JMCwinG{ ' ' }, JCRwinG{ ' ' }, JMCwinS{ ' ' }, JCRwinS{ ' ' };
	string awayLineChars{ ' ' }, homeLineChars{ ' ' };
	cout << endl << endl << endl << "Looping through CGame class variable game: " << endl << endl;
	for (iterG = game.begin(); iterG != game.end(); ++iterG)
	{
		JMCwinG = ' ';
		JCRwinG = ' ';
		JMCwinS = ' ';
		JCRwinS = ' ';
		awayLineChars = ' ';
		homeLineChars = ' ';

		for (int i = 0; i < 173; ++i)
			cout << '-';
		cout << endl;
		if (iterG->GetAwayRank() != "")
			awayRankAndTeam = "#" + iterG->GetAwayRank() + " " + iterG->GetAwayTeam();
		else
			awayRankAndTeam = iterG->GetAwayRank() + " " + iterG->GetAwayTeam();
		if (iterG->GetHomeRank() != "")
			homeRankAndTeam = "#" + iterG->GetHomeRank() + " " + iterG->GetHomeTeam();
		else
			homeRankAndTeam = iterG->GetHomeRank() + " " + iterG->GetHomeTeam();
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

		cout << right << setw(9) << iterG->GetTime();
		cout << right << " | " << setw(7) << iterG->GetAwayConf();
		cout << right << setw(20) << awayRankAndTeam;
		cout << right << setw(5) << awayLineChars;
		cout << " | " << setw(6) << iterG->GetAwayScore() << "   | ";
		cout << setw(20) << iterG->GetTeamGameWinner() << " | ";
		cout << setw(20) << iterG->GetJMCgamePick() << " " << JMCwinG << "|";
		cout << setw(20) << iterG->GetJCRgamePick() << " " << JCRwinG << "|";
		cout << setw(20) << iterG->GetJMCspreadPick() << " " << JMCwinS << "|";
		cout << setw(20) << iterG->GetJCRspreadPick() << " " << JCRwinS << "|";
		cout << endl;

		cout << right << setw(12) << " | " << setw(7) << iterG->GetHomeConf();
		cout << right << setw(20) << homeRankAndTeam;
		cout << right << setw(5) << homeLineChars;
		cout << " | " << setw(6) << iterG->GetHomeScore() << "   | ";
		cout << setw(20) << iterG->GetTeamSpreadWinner() << " | ";
		cout << setw(23) << "|" << setw(23) << "|" << setw(23) << "|" << setw(23) << "|";
		cout << endl;
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
		write << iterG->GetJCRwinSpread() << '\t';
		write << iterG->GetGameType() << '\t';
		write << iterG->GetSeason() << '\t';
		write << iterG->GetSheet() << '\t';
		write << '\n';
	}
	write.close();
	return;
}

int main()
{
	string w;
	vector<string> gameInfo;
	vector<CGame> game;
	vector<CGame>::iterator iterG;
	string fileName;

	fileName = "2016 ExportText.txt";
	//fileName = "2016 Football Picks Master Data.txt";
	ReadFile(game, fileName);
	//fileName = "2016 Football Picks Import.txt";
	//ReadFile(game, fileName);
	PrintGames(game);

	//WriteFile(game, "2016 ExportText.txt");

    return 0;
}

