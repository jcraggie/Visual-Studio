// Pockeenacci_v3.cpp : Defines the entry point for the console application.
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

// version 3 - Permutations (Let's move things around)



#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <array>
#include <iomanip>

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
	int valu;

	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			if (r == 0)
			{
				pos2 = pos + 1;
				if (pos2 >= keySize)
					pos2 = 0;
				valu = key[pos].value + key[pos2].value;
				if (valu > 9)
					valu = valu % 10;
				cipherGrid[r][c] = valu;
				pos += 1;
			}
			else
			{
				fibR = r - 1;
				fibC = c;
				fibC2 = fibC + 1;
				if (fibC2 >= 6)
					fibC2 = 0;
				valu = cipherGrid[fibR][fibC] + cipherGrid[fibR][fibC2];
				if (valu > 9)
					valu = valu % 10;
				cipherGrid[r][c] = valu;
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

	//char textGrid[6][6]{ " " };
	//std::array<std::array<char, 6>, 6> textGrid{ " " };
	char textGrid[6][6];
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


	// version 3 - permutations
	// we'll be shifting the columns down by the numbers in the first row of the key
	// we'll then shift the rows by the numbers in the second row of the key




	//char shiftDown1[6][6]{' '};

	//model 2 dim array using std::array
	//std::array<std::array<int, 3>, 3> arr = { { { 5, 8, 2 },{ 8, 3, 1 },{ 5, 3, 9 } } };

	//std::array<std::array<char, 6>, 6> shiftDown1{ " " };
	char shiftDown1[6][6]{};
	
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			shiftDown1[r][c] = textGrid[r][c];
		}
	}
	//shiftDown1 = textGrid;

	// shifting columns down
	// when shifting columns, col # stays the same; row # changes.
	// if row # = 6, then next row = 0

	int shiftNum = 0;
	int currR = 0;
	int currC = 0; // remains constant for column shifts. only change when moving to next column shift
	int nextR;
	char nextChar;
	char tempChar;
	char currChar;


	// do a table if shift # is 6, 7, 8, or 9
	// taking cipher and % 6 (mod 6) should yield the correct results.
	// shifting = shifting
	//     6          0
	//     7          1
	//     8          2
	//     9          3
	


	for (int c = 0; c < 6; ++c) // shift each column down
	{
		shiftNum = cipherGrid[0][c] % 6; // see table above - taking first row (row 0) of the cipherGrid for this shift
		for (int i = 0; i < shiftNum; ++i) // shifting shiftNum times
		{
			tempChar = shiftDown1[5][c]; // hold last column item in temp. this will be moved to 0,c at the end
			for (int r = 5; r >= 0; --r)
			{
				if (r - 1 < 0)
					shiftDown1[r][c] = tempChar; // if at 0,c, get temp char and put here
				else
					shiftDown1[r][c] = shiftDown1[r - 1][c];
			}
		}
	}


	// output grid
	cout << endl << "This is the shiftDown1 grid after shifting each column: " << endl;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
			cout << shiftDown1[r][c] << " ";
		cout << endl;
	}

	// create new grid for shiftRight1 based on shiftDown1
	char shiftRight1[6][6]{};

	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			shiftRight1[r][c] = shiftDown1[r][c];
		}
	}



	// do a table if shift # is 6, 7, 8, or 9
	// taking cipher and % 6 (mod 6) should yield the correct results.
	// shifting = shifting
	//     6          0
	//     7          1
	//     8          2
	//     9          3
	//
	// now need to shift each row right by num of chars in 2nd row (row 1) of the cipherGrid
	for (int r = 0; r < 6; ++r) // shift each row right
	{
		shiftNum = cipherGrid[1][r] % 6; // see table above - taking second row (row 1) of the cipherGrid for this shift
		for (int i = 0; i < shiftNum; ++i) // shifting shiftNum times
		{
			tempChar = shiftRight1[r][5]; // hold last column item in temp. this will be moved to 0,c at the end
			for (int c = 5; c >= 0; --c)
			{
				if (c - 1 < 0)
					shiftRight1[r][c] = tempChar; // if at 0,c, get temp char and put here
				else
					shiftRight1[r][c] = shiftRight1[r][c - 1];
			}
		}
	}

	// output grid
	cout << endl << "This is the shiftRight1 grid after shifting each column: " << endl;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
			cout << shiftRight1[r][c] << " ";
		cout << endl;
	}

	// version 3-2 - substitution (Let's change things completely).
	// now that we have shifted each column and each row, we cant to actually change their value.
	// this is done through what's called a substitution box, or S-BOX. This cipher uses two kinds:
	// one kind that simply changes tthe value of each letter, which is what we'll use now AND
	// one that's called a "look-up table", where values are mapped out using coordinates. that is later.
	// this key should be the 3rd row (row 2) in the cipherGrid..... 808688 based on SECRET being the key.
	// starting with 0,0 (T), we want to shift it's value forward in the alphabet by 8 spaces. The next letter
	// (E) will move foward 0 spaces. We re-use the 808688 key for EACH ROW in the grid. Also keep in mind our alphabet
	// is alphanumeric, so it doesn't end with Z. It is actually A-Z followed by 0-9. This makes up 36 characters, which
	// is why we've chosen a 6x6 grid. When doing your shifts, if you letter is Y and you need to shift it 3 spaces,
	// you would count like this.... Z, 0, 1. The new value for Y shifted 3 spaces is 1.


	char sBox[36]
	{ 'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
		'0','1','2','3','4','5','6','7','8','9' };

	cout << endl;
	// testing s-box lookup -------------------------------------------------
	for (int i = 0; i < 36; ++i)
	{
		cout << setw(3) << sBox[i];
	}
	cout << endl;

	for (int i = 0; i < 36; ++i)
	{
		cout << setw(3) << i;
	}
	cout << endl;

	char chars[4]{ 0 }, cNew;
	int idx, newIdx, j;

	chars[0] = 'W';
	chars[1] = 'Z';
	chars[2] = '8';
	chars[3] = 'K';
	for (j = 0; j < 4; ++j)
	{
		for (int i = 0; i < 36; ++i)
			if (sBox[i] == chars[j])
			{
				idx = i;
				newIdx = (idx + 7) % 36;

				cNew = sBox[newIdx];
			}

		cout << "Char c1: " << chars[j] << " is located at " << idx << " and 7 chars from that is " << cNew << " located at " << newIdx << endl;
	}
	// end s-box testing -----------------------------------------------------

	// create sBox grid for lookups
	// create new grid for shiftRight1 based on shiftDown1
	char sBoxGrid[6][6]{};

	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			sBoxGrid[r][c] = shiftRight1[r][c];
		}
	}
	

	// now need to shift each row right by num of chars in 2nd row (row 1) of the cipherGrid
	for (int r = 0; r < 6; ++r) // iterate through each row
	{
		for (int c = 0; c < 6; ++c)
		{
			shiftNum = cipherGrid[2][c]; // using 3rd row (row 2) of cipherGrid for s-box lookups. use this same crypto for all 6 rows.
			//cout << "Cipher is " << shiftNum;
			for (int i = 0; i < 36; ++i)
				if (sBox[i] == sBoxGrid[r][c])
				{
					//cout << "  Changing " << sBoxGrid[r][c] << " at " << r << "," << c << " to ";
					idx = i;
					newIdx = (idx + shiftNum) % 36;

					sBoxGrid[r][c] = sBox[newIdx];
					//cout << sBoxGrid[r][c] << endl;
					break;
				}

		}
		
	}


	// output grid
	cout << endl << "This is sBoxGrid after looking up each row in the sBox array: " << endl;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
			cout << sBoxGrid[r][c] << " ";
		cout << endl;
	}







	return 0;
}

