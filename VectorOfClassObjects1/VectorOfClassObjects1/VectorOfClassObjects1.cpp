// VectorOfClassObjects1.cpp : Defines the entry point for the console application.
// testing idea for vector of classes for Pockenacci project.

#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;



class KeyChar
{
public:
	char c;
	int  pos;
	int  sort_pos;
	int  value;
};

bool SortByChar(const KeyChar& a, const KeyChar& b)
{
	return a.c < b.c;
}

bool OriginalOrder(const KeyChar& a, const KeyChar& b)
{
	return a.pos < b.pos;
}

int main()
{
	string keyString("SECRET");
	vector<char> vKey(keyString.begin(), keyString.end()); // puts individual chars into vector vKey
	vector<char>::const_iterator iterC;
	vector<KeyChar>::iterator iterK;
	vector<KeyChar> key;

	int pos = 0;

	for (iterC = vKey.begin(); iterC != vKey.end(); ++iterC)
	{
		KeyChar* newKey = new KeyChar;
		newKey->c = *iterC;
		newKey->pos = pos + 1;
		pos += 1;
		key.push_back(*newKey);
	}

	

	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << iterK->c << " pos " << iterK->pos << endl;
	}

	cout << endl << "Sorting now." << endl;

	std::sort(key.begin(), key.end(), SortByChar);

	pos = 0;
	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		iterK->sort_pos = pos + 1;
		cout << "char: " << iterK->c << " pos: " << iterK->pos << " sort_pos: " << iterK->sort_pos << endl;
		pos += 1;
	}
	cout << endl;

	cout << "returning to original order: " << endl;

	std::sort(key.begin(), key.end(), OriginalOrder);

	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << "char: " << iterK->c << " pos: " << iterK->pos << " sort_pos: " << iterK->sort_pos << endl;
	}
	cout << endl;

	return 0;
}

