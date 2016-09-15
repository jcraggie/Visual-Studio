// HIghScores1.cpp : Defines the entry point for the console application.
// From Beginning C++ Through Game Programming 4th Edition by Michael Dawson
//
// demonstrates algorithms

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <algorithm>
#include <ctime>
#include <cstdlib>

using namespace std;



int main()
{
	vector<int>::const_iterator iter;

	cout << "Creating a list of scores.";
	vector<int> scores;
	scores.push_back(1500);
	scores.push_back(3500);
	scores.push_back(7500);

	cout << endl << "High Scores:" << endl;
	for (iter = scores.begin(); iter != scores.end(); ++iter)
	{
		cout << *iter << endl;
	}

	cout << endl << "Finding a score.";
	int score;
	cout << endl << "Enter a score to find: ";
	cin >> score;
	getchar();
	iter = find(scores.begin(), scores.end(), score);
	if (iter != scores.end())
	{
		cout << "Score found." << endl;
	}
	else
	{
		cout << "Score not found." << endl;
	}

	cout << endl << "Randomizing scores.";

	srand(static_cast<unsigned int>(time(0)));
	random_shuffle(scores.begin(), scores.end());
	cout << endl << "High Scores: " << endl;
	for (iter = scores.begin(); iter != scores.end(); ++iter)
	{
		cout << *iter << endl;
	}

	cout << endl << "Sorting scores: ";
	sort(scores.begin(), scores.end());
	cout << endl << "High Scores: " << endl;
	for (iter = scores.begin(); iter != scores.end(); ++iter)
	{
		cout << *iter << endl;
	}

	cout << endl << endl;
	cout << "Press any key to end the program....";
	getchar();


    return 0;
}

