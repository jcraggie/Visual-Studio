// Pockenacci_v1-1.cpp : Defines the entry point for the console application.
// v1-1 is rewriting using vector of classes
//
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



class CKeyChar
{
public:
	char c;
	int  pos;
	int  value;
};

bool SortByChar(const CKeyChar& a, const CKeyChar& b)
{
	return a.c < b.c;
}

bool OriginalOrder(const CKeyChar& a, const CKeyChar& b)
{
	return a.pos < b.pos;
}

int main()
{
	string keyString("SECRET");
	vector<char> vKey(keyString.begin(), keyString.end()); // puts individual chars into vector vKey
	vector<char>::const_iterator iterC;
	vector<CKeyChar>::iterator iterK;
	vector<CKeyChar> key;

	int pos = 0;

	for (iterC = vKey.begin(); iterC != vKey.end(); ++iterC)
	{
		CKeyChar* newKey = new CKeyChar;
		newKey->c = *iterC;
		newKey->pos = pos + 1;
		pos += 1;
		key.push_back(*newKey);
	}



	//for (iterK = key.begin(); iterK != key.end(); ++iterK)
	//{
	//	cout << iterK->c << " pos " << iterK->pos << endl;
	//}

	//cout << endl << "Sorting now." << endl;

	std::sort(key.begin(), key.end(), SortByChar);

	pos = 0;
	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		iterK->value = pos + 1;
		//cout << "char: " << iterK->c << " pos: " << iterK->pos << " value: " << iterK->value << endl;
		pos += 1;
	}
	cout << endl;

	//cout << "returning to original order: " << endl;

	std::sort(key.begin(), key.end(), OriginalOrder);

	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << iterK->c << " ";
	}
	cout << endl;

	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << iterK->value << " ";
	}
	cout << endl;

	return 0;
}

