// VectorOfClassObjects1.cpp : Defines the entry point for the console application.
// testing idea for vector of classes for Pockenacci project.

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

	

	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << iterK->c << " pos " << iterK->pos << endl;
	}

	cout << endl << "Sorting now." << endl;

	std::sort(key.begin(), key.end(), SortByChar);

	pos = 0;
	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		iterK->value = pos + 1;
		cout << "char: " << iterK->c << " pos: " << iterK->pos << " value: " << iterK->value << endl;
		pos += 1;
	}
	cout << endl;

	cout << "returning to original order: " << endl;

	std::sort(key.begin(), key.end(), OriginalOrder);

	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << "char: " << iterK->c << " pos: " << iterK->pos << " value: " << iterK->value << endl;
	}
	cout << endl;

	return 0;
}

