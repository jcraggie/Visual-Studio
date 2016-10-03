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


int main()
{
	vector<string> line;
	string str;
	string w;
	string gameLine;
	//vector<char> parseLine;
	vector<string>::iterator iterC;
	string word;
	vector<string> gameInfo;
	int wordCount = 0;
	int amt = 0;
	vector<CGame> game;
	vector<CGame>::iterator iterG;


	//ofstream myFile("2016gameData1.txt");
	//if (myFile.is_open())
	//{
	//	myFile << "This is line 1." << endl;
	//	myFile << "This is line 2." << endl;
	//	myFile.close();
	//}
	//else cout << "Unable to open file to write." << endl;

	ifstream myFile2("2016 Football Picks4-1.txt");
	//ifstream myFile2 ("2016gameData1.txt");
	while (myFile2)
	{
		getline(myFile2,str);
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
					amt = std::stoi(word);
					newGame->SetUDPts(amt);
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
				}
				word = "";
			}

			
		}
		game.push_back(*newGame);
		//cout << setw(15) << word;
		word = "";
		//cout << endl;
		
	}
	std::string awayRankAndTeam;
	std::string homeRankAndTeam;
	cout << endl << endl << endl << "Looping through CGame class variable game: " << endl << endl;
	for (iterG = game.begin(); iterG != game.end(); ++iterG)
	{
		cout << "--------------------------------------------------------------------------------------------------------------------------------------------------" << endl;
		if (iterG->GetAwayRank() != "")
			awayRankAndTeam = "#" + iterG->GetAwayRank() + " " + iterG->GetAwayTeam();
		else
			awayRankAndTeam = iterG->GetAwayRank() + " " + iterG->GetAwayTeam();
		if (iterG->GetHomeRank() != "")
			homeRankAndTeam = "#" + iterG->GetHomeRank() + " " + iterG->GetHomeTeam();
		else
			homeRankAndTeam = iterG->GetHomeRank() + " " + iterG->GetHomeTeam();
		cout << right << setw(9) << iterG->GetTime();
		cout << right << setw(7) << iterG->GetAwayConf();
		//cout << setw(3) << iterG->GetAwayRank();
		cout << right << setw(20) << awayRankAndTeam;
		if (iterG->GetUDTeam() == iterG->GetAwayTeam())
			cout << right << setw(2) << "+" << left << setw(3) << abs(iterG->GetUDPts()) << right;
		else
			cout << right << setw(5) << " ";
		//cout << right << setw(7) << iterG->GetAwayConf();
		cout << setw(3) << iterG->GetAwayScore();
		cout << setw(20) << iterG->GetTeamGameWinner();
		cout << setw(20) << iterG->GetJMCgamePick();
		cout << setw(20) << iterG->GetJCRgamePick();
		cout << setw(20) << iterG->GetJMCspreadPick();
		cout << setw(20) << iterG->GetJCRspreadPick();
		cout << endl;
		//cout << setw(12) << iterG->GetHomeRank();
		cout << right << setw(16) << iterG->GetHomeConf();
		cout << right << setw(20) << homeRankAndTeam;
		if (iterG->GetUDTeam() == iterG->GetHomeTeam())
			cout << right << setw(2) << "+" << left << setw(3) << abs(iterG->GetUDPts()) << right;
		else
			cout << right << setw(5) << " ";
		//cout << right << setw(7) << iterG->GetHomeConf();
		cout << setw(3) << iterG->GetHomeScore();
		cout << setw(20) << iterG->GetTeamSpreadWinner();
		cout << endl;
	}


    return 0;
}

