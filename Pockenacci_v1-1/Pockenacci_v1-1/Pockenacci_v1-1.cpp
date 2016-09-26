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

	int cipherGrid[6][6]{}; // 6x6 grid using int

	//vector<vector<char>> cipherGrid(6, vector<char>(6)); // define 6x6 vector grid addressed as cipherGrid[r][c]
	// std::string s = std::to_string(5); // use this to change an int to char;

	int pos = 0;

	// assign each character to a class CKeyChar object and assign a numerical position pos
	// pos will be used to return the key to the original order after being alpha sorted below
	for (iterC = vKey.begin(); iterC != vKey.end(); ++iterC)
	{
		CKeyChar* newKey = new CKeyChar;
		newKey->c = *iterC;
		newKey->pos = pos + 1;
		pos += 1;
		key.push_back(*newKey);
	}

	// sort by character. put original key characters in alpha order
	std::sort(key.begin(), key.end(), SortByChar);

	// assign numerical values to the sorted characters. duplicates go left to right.
	pos = 0;
	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		iterK->value = pos + 1;
		pos += 1;
	}
	cout << endl;

	// return the keys to the original order
	std::sort(key.begin(), key.end(), OriginalOrder);

	// output the key and it's value
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

	cout << "The size of key is: " << key.size() << endl;

	int keySize = key.size();
	
	//cout << key[0].c << " " << key[0].value << endl;


	


	// end of output

	// -------------------- MISTAKE BELOW
	//iterK = key.begin();
	//for (int r = 0; r < 6; ++r)
	//{
	//	for (int c = 0; c < 6; ++c)
	//	{
	//		if (iterK == key.end())
	//		{
	//			break;
	//		}
	//		else
	//		{
	//			cipherGrid[r][c] = iterK->value;
	//			++iterK; // need to test for iterK = key.end()
	//		}
	//		
	//	}
	//}
	// ---------------------------ABOVE IS MISTAKE. THE INITIAL KEY IS NOT PART OF THE 6X6 CIPHER
	
	pos = 0;
	int pos2;
	int fibR, fibC, fibC2;
	int val;

	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			if (r == 0)
			{
				pos2 = pos + 1;
				if (pos2 >= keySize)
					pos2 = 0;
				val = key[pos].value + key[pos2].value;
				if (val > 9)
					val = val % 10;
				cipherGrid[r][c] = val;
				pos += 1;
			}
			else
			{
				fibR = r - 1;
				fibC = c;
				fibC2 = fibC + 1;
				if (fibC2 >= 6)
					fibC2 = 0;
				val = cipherGrid[fibR][fibC] + cipherGrid[fibR][fibC2];
				if (val > 9)
					val = val % 10;
				cipherGrid[r][c] = val;
				pos += 1;
			}

			
		}
	}


	// output grid
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
			cout << cipherGrid[r][c] << " ";
		cout << endl;
	}









	return 0;
}

