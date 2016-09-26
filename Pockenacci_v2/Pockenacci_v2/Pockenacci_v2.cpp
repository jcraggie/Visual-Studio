// Pockenacci_v2.cpp : Defines the entry point for the console application.
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
// version 2 will be Loading Plaintext (A message to encrypt).
// see notes below


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


	// version 2 will be Loading Plaintext (A message to encrypt).
	// now that we have a key, we need something to encrypt.
	// let's say we want to encrypt the message "THIS IS A SECRET MESSAGE THAT WE NEED TO HIDE"
	// we'll use a 6x6 grid becuase it nicely allows us to encrypt A-Z and 0 - 9 (36 possible characters). This means we can
	// encrypt 36 chars at a time, in a 6x6 "block". This type of cipher is called a "block cipher". We'll write our message from 
	// left to right, starting with the upper left most square.
	// This message just happens to be 36 characters for our example. If the message is shorter, you can pad it with random chars.
	// If it is longer, you'll need to split into multiple blocks.
	// first need to put plaintext message into 6x6 array of chars

	string plainText = "THIS IS A SECRET MESSAGE THAT WE NEED TO HIDE";

	char textGrid[6][6]{ " " };
	vector<char> vPlainText(plainText.begin(), plainText.end()); // puts individual chars into vector vKey
	// can user iterC from earlier
	vector<char> vNoSpacesText;
	vector<char>::iterator iterC2;

	iterC = vPlainText.begin();
	
	for (iterC = vPlainText.begin(); iterC != vPlainText.end(); ++iterC)
	{
		if (*iterC != ' ')
			vNoSpacesText.push_back(*iterC);
	}


	// put plaintext into grid. need to figure out how to strip out the spaces
	iterC = vNoSpacesText.begin();
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			if (iterC == vNoSpacesText.end())
			{
				break;
			}
			else
			{
				textGrid[r][c] = *iterC;
				++iterC;
			}
			
		}
	}





	// output grid
	cout << endl << "This is the plain text message to be encrypted: " << endl;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
			cout << textGrid[r][c] << " ";
		cout << endl;
	}



	return 0;
}

