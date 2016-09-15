// Swap1.cpp : Defines the entry point for the console application.
// from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
//
// entered by JCR 2016-09-15
// demonstrates passing references to alter argument variables

#include "stdafx.h"
#include <iostream>

using namespace std;

void badSwap(int x, int y);
void goodSwap(int& x, int& y);


int main()
{
	int myScore = 150;
	int yourScore = 1000;

	cout << "Original values" << endl;
	cout << "myScore: " << myScore << endl;
	cout << "yourScore: " << yourScore << endl << endl;

	cout << "Calling badSwap()" << endl;
	badSwap(myScore, yourScore);
	cout << "myScore: " << myScore << endl;
	cout << "yourScore: " << yourScore << endl << endl;

	cout << "Calling goodSwap()" << endl;
	goodSwap(myScore, yourScore);
	cout << "myScore: " << myScore << endl;
	cout << "yourScore: " << yourScore << endl << endl;

	cout << "Press any key to end the game.";
	getchar();

    return 0;
}

void badSwap(int x, int y)
{
	int temp = x;
	x = y;
	y = temp;
}

void goodSwap(int& x, int& y)
{
	int temp = x;
	x = y;
	y = temp;
}

