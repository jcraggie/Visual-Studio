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
// now that we have a key, we need something to encrypt.
// let's say we want to encrypt the message "THIS IS A SECRET MESSAGE THAT WE NEED TO HIDE"
// we'll use a 6x6 grid becuase it nicely allows us to encrypt A-Z and 0 - 9 (36 possible characters). This means we can
// encrypt 36 chars at a time, in a 6x6 "block". This type of cipher is called a "block cipher". We'll write our message from 
// left to right, starting with the upper left most square.
// This message just happens to be 36 characters for our example. If the message is shorter, you can pad it with random chars.
// If it is longer, you'll need to split into multiple blocks.
// first need to put plaintext message into 6x6 array of chars

// version 3 - Permutations (Let's move things around)
// we'll be shifting the columns down by the numbers in the first row of the key
// we'll then shift the rows by the numbers in the second row of the key
// NOTE
// if shift # is 6, 7, 8, or 9 taking cipher and % 6 (mod 6) should yield the correct results.
// shifting = shifting
//     6          0
//     7          1
//     8          2
//     9          3

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


// version 3-3 Mesasge Authentication Codes (Check yourself!) MAC
//





 
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

void CopyGrid(char orig[6][6], char newarr[6][6])
{
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			newarr[r][c] = orig[r][c];
		}
	}
}

void CopyGrid(int orig[6][6], int newarr[6][6])
{
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			newarr[r][c] = orig[r][c];
		}
	}
}

void OutputGrid(char grid[6][6], string msg)
{
	cout << endl << msg << endl;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
			cout << grid[r][c] << " ";
		cout << endl;
	}
}

void OutputGrid(int grid[6][6], string msg)
{
	cout << endl << msg << endl;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
			cout << grid[r][c] << " ";
		cout << endl;
	}
}

void LookUpGrid(const char searchGrid[6][6], char findMe, int& fRow, int& fCol)
{
	for (int r = 0; r < 6; ++r)
		for (int c = 0; c < 6; ++c)
			if (searchGrid[r][c] == findMe)
			{
				fRow = r;
				fCol = c;
				return;
			}
}

template <typename T>
T GetLookUp(T t1, T LookUp[37], int& aSize)
{
	string typ1 = typeid(T).name();
	//int aSize = 0;
	if (typ1 == "char")
	{
		for (char ichar = 'A'; ichar <= 'Z'; ++ichar)
		{
			LookUp[aSize] = ichar;
			aSize += 1;
		}
		for (char ichar = '0'; ichar <= '9'; ++ichar)
		{
			LookUp[aSize] = ichar;
			aSize += 1;
		}
		LookUp[aSize] = '\0';
		//LookUp[36]
		//{ 'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
		//	'0','1','2','3','4','5','6','7','8','9' };
		//cout << " Type is: " << typ1 << " ";
		//cout << "LookUp is " << LookUp << endl;
	}
	else
	{
		for (aSize = 0; aSize <= 9; ++aSize)
		{
			LookUp[aSize] = aSize;
		}
		LookUp[aSize] = '\0';
		//LookUp[10]{ 0,1,2,3,4,5,6,7,8,9 };
		//cout << " Type is: " << typ1 << " ";
		//cout << "LookUp is " << LookUp << endl;
		aSize = 10;
	}

	return 0;
}

template <typename T>
void ShiftGridDown(T grid[6][6], int const cipher[6][6], int cipherRow)
{
	int shiftNum;
	int temp;
	for (int c = 0; c < 6; ++c) // shift each column down
	{
		shiftNum = cipher[cipherRow][c] % 6; // see table above - taking first row (row 0) of the cipherGrid for this shift
		for (int i = 0; i < shiftNum; ++i) // shifting shiftNum times
		{
			temp = grid[5][c]; // hold last column item in temp. this will be moved to 0,c at the end
			for (int r = 5; r >= 0; --r)
			{
				if (r - 1 < 0)
					grid[r][c] = temp; // if at 0,c, get temp char and put here
				else
					grid[r][c] = grid[r - 1][c];
			}
		}
	}
}
template <typename T>
void ShiftGridUp(T grid[6][6], int const cipher[6][6], int cipherRow)
{
	int shiftNum;
	T temp;
	for (int c = 0; c < 6; ++c) // shift each column down
	{
		shiftNum = cipher[cipherRow][c] % 6; // see table above - taking first row (row 0) of the cipherGrid for this shift
		for (int i = 0; i < shiftNum; ++i) // shifting shiftNum times
		{
			temp = grid[0][c]; // hold last column item in temp. this will be moved to 0,c at the end
			for (int r = 0; r <= 5; ++r)
			{
				if (r + 1 > 5)
					grid[r][c] = temp; // if at 0,c, get temp char and put here
				else
					grid[r][c] = grid[r + 1][c];
			}
		}
	}
}

template <typename T>
void ShiftGridRight(T grid[6][6], int cipher[6][6], int cipherRow)
{
	int shiftNum;
	T temp;
	for (int r = 0; r < 6; ++r) // shift each row right
	{
		shiftNum = cipher[cipherRow][r] % 6; // see table above - taking second row (row 1) of the cipherGrid for this shift
		for (int i = 0; i < shiftNum; ++i) // shifting shiftNum times
		{
			temp = grid[r][5]; // hold last column item in temp. this will be moved to 0,c at the end
			for (int c = 5; c >= 0; --c)
			{
				if (c - 1 < 0)
					grid[r][c] = temp; // if at 0,c, get temp char and put here
				else
					grid[r][c] = grid[r][c - 1];
			}
		}
	}
}
template <typename T>
void ShiftGridLeft(T grid[6][6], int const cipher[6][6], int cipherRow)
{
	int shiftNum;
	T temp;
	for (int r = 0; r < 6; ++r) // shift each row right
	{
		shiftNum = cipher[cipherRow][r] % 6; // see table above - taking second row (row 1) of the cipherGrid for this shift
		for (int i = 0; i < shiftNum; ++i) // shifting shiftNum times
		{
			temp = grid[r][0]; // hold last column item in temp. this will be moved to 0,c at the end
			for (int c = 0; c <= 5; ++c)
			{
				if (c + 1 > 5)
					grid[r][c] = temp; // if at 0,c, get temp char and put here
				else
					grid[r][c] = grid[r][c + 1];
			}
		}
	}
}

void CreateCipherGrid(vector<CKeyChar> key, int cipher[6][6])
{
	int keySize = key.size();

	int pos = 0;
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
				cipher[r][c] = valu;
				pos += 1;
			}
			else
			{
				fibR = r - 1;
				fibC = c;
				fibC2 = fibC + 1;
				if (fibC2 >= 6)
					fibC2 = 0;
				valu = cipher[fibR][fibC] + cipher[fibR][fibC2];
				if (valu > 9)
					valu = valu % 10;
				cipher[r][c] = valu;
				pos += 1;
			}


		}
	}
}

template <typename T>
void ShiftGridForward(T grid[6][6], int const cipher[6][6], int whichCipherRow)
{
	int idx, newIdx;
	T LookUp[37];
	int shiftNum;
	int aSize = 0;
	GetLookUp(grid[0][0], LookUp, aSize);

	for (int r = 0; r < 6; ++r) // iterate through each row
	{
		for (int c = 0; c < 6; ++c)
		{
			shiftNum = cipher[whichCipherRow][c]; // using 3rd row (row 2) of cipherGrid for s-box lookups. use this same crypto for all 6 rows.
			for (int i = 0; i < aSize; ++i)
				if (LookUp[i] == grid[r][c])
				{
					idx = i;
					newIdx = (idx + shiftNum) % aSize;

					grid[r][c] = LookUp[newIdx];
					break;
				}

		}

	}
}
template <typename T>
void ShiftGridBackward(T grid[6][6], int const cipher [6][6], int whichCipher)
{
	T LookUp[37];
	int aSize = 0;
	GetLookUp(grid[0][0], LookUp, aSize);

	int shiftNum;
	int idx, newIdx;
	for (int r = 0; r < 6; ++r) // iterate through each row
	{
		for (int c = 0; c < 6; ++c)
		{
			shiftNum = cipher[whichCipher][c]; // using 3rd row (row 2) of cipherGrid for s-box lookups. use this same crypto for all 6 rows.

			for (int i = 0; i < aSize; ++i)
				if (LookUp[i] == grid[r][c])
				{
					idx = i;
					newIdx = (idx - shiftNum);
					if (newIdx < 0)
					{
						newIdx = aSize - abs(newIdx);
					}
					grid[r][c] = LookUp[newIdx];
					break;
				}

		}

	}
}

void PopulateKeyCharClass(vector<CKeyChar>& key, const string keyString)
{
	// assign each character to a class CKeyChar object and assign a numerical position pos
	// pos will be used to return the key to the original order after being alpha sorted below

	vector<char> vKey(keyString.begin(), keyString.end()); // puts individual chars into vector vKey
	vector<char>::const_iterator iterC;
	int pos = 0;

	for (iterC = vKey.begin(); iterC != vKey.end(); ++iterC)
	{
		CKeyChar* newKey = new CKeyChar;
		newKey->c = *iterC;
		newKey->pos = pos + 1;
		pos += 1;
		key.push_back(*newKey);
	}
}

void CreateCipherKeys(vector<CKeyChar>& key)
{
	int pos;
	vector<CKeyChar>::iterator iterK;

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
}

void OutputCipherKey(vector<CKeyChar> key)
{
	vector<CKeyChar>::iterator iterK;

	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << iterK->c << " ";
	}
	cout << endl;

	// output the key values
	for (iterK = key.begin(); iterK != key.end(); ++iterK)
	{
		cout << iterK->value << " ";
	}
	cout << endl;
}

void GetTextToEncrypt(string& plainText, vector<char>& noSpaceText)
{
	vector<char>::const_iterator iterC;
	plainText = "THIS IS A SECRET MESSAGE THAT WE NEED TO HIDE";
	cout << "The message to encode is: " << plainText << endl;
	vector<char> vPlainText(plainText.begin(), plainText.end()); // puts individual chars into vector vPlainText

	iterC = vPlainText.begin();

	for (iterC = vPlainText.begin(); iterC != vPlainText.end(); ++iterC)
	{
		if (*iterC != ' ')
			noSpaceText.push_back(*iterC);
	}

}

void CreateTextGrid(vector<char> noSpaceText, char textGrid[6][6])
{
	vector<char>::iterator iterC;

	iterC = noSpaceText.begin();

	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			if (iterC == noSpaceText.end())
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
}

void CreateSBoxGrid(char sBoxGrid[6][6])
{
	char sBox[36]
	{ 'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
		'0','1','2','3','4','5','6','7','8','9' };
	int sBoxIdx = 0; // index used to iterate through the sBox array and put it in the sBoxGrid

	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			sBoxGrid[r][c] = sBox[sBoxIdx];
			sBoxIdx += 1;
		}
	}
}

void CreateMACGrid(int macGrid[6][6], char sBoxGrid[6][6], int cipherGrid[6][6], char shiftForward[6][6])
{
	char findMe;
	char macChar;
	int macInt;
	int fRow, fCol;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			findMe = shiftForward[r][c];
			LookUpGrid(sBoxGrid, findMe, fRow, fCol);
			macInt = cipherGrid[fRow][fCol];
			//cout << "macInt" << macInt << endl;
			macGrid[r][c] = macInt;

		}
	}
}

void DeCreateMACGrid(char shiftForward[6][6], char sBoxGrid[6][6], int cipherGrid[6][6], int macGrid[6][6])
{
	char findMe;
	char macChar;
	int macInt;
	int fRow, fCol;
	for (int r = 0; r < 6; ++r)
	{
		for (int c = 0; c < 6; ++c)
		{
			findMe = shiftForward[r][c];
			LookUpGrid(sBoxGrid, findMe, fRow, fCol);
			macInt = cipherGrid[fRow][fCol];
			//cout << "macInt" << macInt << endl;
			macGrid[r][c] = macInt;

		}
	}
}

void GetKeyFromUser(string& keyString)
{
	int slen;
	bool hasNums = false;
	cout << "You need a 6-alpha character key. Case does not matter. No spaces." << endl;
	cout << "This will be used to generate a 36 alpha-numeric key grid used to encrypt" << endl;
	cout << "your message." << endl << endl;
	do
	{
		slen = 0;
		hasNums = false;
		cout << "Enter your 6 character key: ";

		getline(cin, keyString);
		transform(keyString.begin(), keyString.end(), keyString.begin(), toupper);
		slen = keyString.length();
		if (slen > 6)
			cout << endl << "Your input is more than 6 characters. Please try again." << endl;
		else if (slen < 6)
			cout << endl << "Your input is less than 6 characters. Please try again." << endl;
		else if (string::npos != keyString.find_first_of("0123456789 "))
		{
			cout << endl << "Your input contains numbers and/or spaces. Please try again." << endl;
			hasNums = true;
		}
	} while ((slen > 6) || (slen < 6) || (hasNums == true));
}



int main()
{
	//string keyString("SECRET");
	string keyString;
	string plainText;
	vector<char> noSpaceText;
	char textGrid[6][6];
	char sBoxGrid[6][6]{};
	vector<CKeyChar> key;
	vector<CKeyChar>* pKey;
	int cipherGrid[6][6]{}; // 6x6 grid using int
	int macGrid[6][6]{};

	GetKeyFromUser(keyString);


	PopulateKeyCharClass(key, keyString);
	CreateCipherKeys(key);
	OutputCipherKey(key);
	CreateCipherGrid(key, cipherGrid);
	GetTextToEncrypt(plainText, noSpaceText);
	CreateTextGrid(noSpaceText, textGrid);
	OutputGrid(textGrid, "This is the text to be encrypted in a 6xt6 block.");
	
	// NEXT - MOVE ALL BELOW TO FUNCTION CALLED ENCRYPT

	ShiftGridDown(textGrid, cipherGrid, 0);
	ShiftGridRight(textGrid, cipherGrid, 1);
	ShiftGridForward(textGrid, cipherGrid,2);
	OutputGrid(textGrid, "This is the final Cipher:");
	CreateSBoxGrid(sBoxGrid);
	CreateMACGrid(macGrid, sBoxGrid, cipherGrid, textGrid);
	ShiftGridRight(macGrid, cipherGrid, 3);
	ShiftGridDown(macGrid, cipherGrid, 4);
	ShiftGridForward(macGrid, cipherGrid, 5);
	OutputGrid(macGrid, "This is the mac grid shifted forward:");

	// DECRYPTING

	ShiftGridBackward(macGrid, cipherGrid, 5);
	ShiftGridUp(macGrid, cipherGrid, 4);
	ShiftGridLeft(macGrid, cipherGrid, 3);
	
	DeCreateMACGrid(textGrid, sBoxGrid, cipherGrid, macGrid);
	ShiftGridBackward(textGrid, cipherGrid, 2);
	ShiftGridLeft(textGrid, cipherGrid, 1);
	ShiftGridUp(textGrid, cipherGrid, 0);

	OutputGrid(textGrid, "Original text grid.");

	return 0;
}

