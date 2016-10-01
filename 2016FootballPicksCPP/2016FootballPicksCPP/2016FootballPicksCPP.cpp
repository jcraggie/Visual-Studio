// 2016FootballPicksCPP.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <algorithm>
#include <iomanip>

using namespace std;

class Game
{
private:
	string m_Away;
	string m_Home;
	string m_UD;
	int m_UDpts;
	string m_Date;
	string m_Time;
	string m_AwayConf;
	string m_HomeConf;
	int m_AwayScore;
	int m_HomeScore;
	string m_WinnerGame;
	string m_WinnerSpread;
	
};

int main()
{
	vector<string> line;
	string str;
	string w;
	string game;
	//vector<char> parseLine;
	vector<string>::iterator iterC;
	string word;
	vector<string> gameInfo;


	//ofstream myFile("2016gameData1.txt");
	//if (myFile.is_open())
	//{
	//	myFile << "This is line 1." << endl;
	//	myFile << "This is line 2." << endl;
	//	myFile.close();
	//}
	//else cout << "Unable to open file to write." << endl;

	ifstream myFile2 ("2016gameData1.txt");
	while (myFile2)
	{
		getline(myFile2,str);
		line.push_back(str);

		cout << str << endl;
	}

	for (iterC = line.begin(); iterC != line.end(); ++iterC)
	{
		game = *iterC; // 1 word
		//cout << "game size is: " << game.size() << endl;
		//cout << "Word is: " << w << endl;
		for (int i = 0; i < game.size(); ++i)
		{
			if (game[i] != '\t') // if the char is not a tab
			{
				word.push_back(game[i]); // push the char found to word. once encounter tab, word is done.
			}
			else
			{
				cout << setw(15) << word;
				word = "";
			}

			
		}
		cout << setw(15) << word;
		word = "";
		cout << endl;
		
	}



    return 0;
}

