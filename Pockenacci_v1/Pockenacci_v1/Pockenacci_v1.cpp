// Pockenacci_v1.cpp : Defines the entry point for the console application.
// taken from Github by justin troutman
// printed off github 9/14/2016
//
// version 1 involves the key.
// First we need a key; let's start with a keyword: SECRET
//
// Now we need to convert this keyword into numbers; we do that by numbering each letter based on wehre it appears in the 
// alphabet. If the keyword has two or more of the same letters, we number them from left to right.
//
// S E C R E T
// 5 2 1 4 3 6
//
// in alphabetical order, "C" appears in the alphabet before the other letters, so it gets the number "1". There are two instances
// of the letter "E", which is the next letter in the alphabetical order. Since we go from left to right, the first "E" get the number "2",
// while the 2nd "E" gets the number 3. When we finish the process, we get 5 2 1 4 3 6.
//


#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;


int main()
{
	string key("SECRET");
	vector<char> vKeyChar(key.begin(), key.end());
	vector<int>vKeyInt;
	vector<char>::const_iterator iterC;
	vector<int>::const_iterator iterI;
	int intGrid[6][6];
	char charGrid[6][6];

	sort(vKeyChar.begin(), vKeyChar.end());
	int i = 1;
	for (iterC = vKeyChar.begin(); iterC != vKeyChar.end(); ++iterC)
	{
		vKeyInt.push_back(i);
		cout << *iterC;
		i++;
	}
	cout << endl;
	
	for (iterI = vKeyInt.begin(); iterI != vKeyInt.end(); ++iterI)
	{
		cout << *iterI;
	}

	cout << endl;

	

	cin.get();

    return 0;
}

