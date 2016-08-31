// Bunnies.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <time.h> // used for random number generator
#include "Bunny.h" // created by JCR
#define _WIN32_WINNT 0x0500 // need to define this before including windows.h used for console resizing
#include <Windows.h>
using namespace std;







bool convertToRMVB()
{
	int const RMVB_PERCENT = 2;
	
	// should only return TRUE RMVB_PERCENT of the time
	return(rand() % 100) < RMVB_PERCENT;
}

void printBunnyList(vector<Bunny>& bunnyList)
{
	 // print list of bunnies
	vector<Bunny>::iterator it;
	
	for (it = bunnyList.begin(); it != bunnyList.end(); ++it)
	{
		it->printBunny();
	}
}

void increaseAllAges(vector<Bunny>& bunnyList)
{
	vector<Bunny>::iterator it;
	for (it = bunnyList.begin(); it != bunnyList.end(); ++it)
	{
		//DEBUG cout << "from amin: old age is: " << it->getAge();
		it->increaseAge();
		//DEBUG cout << "  from main: new age is: " << it->getAge() << endl;
	}
	//DEBUG printBunnyList(bunnyList);
}


int main()
{
	// run this only once per program execution
	srand((unsigned)time(NULL)); // generates random seed each time program is run

	// code to resize console window
	HWND console = GetConsoleWindow();
	RECT r;
	GetWindowRect(console, &r); // stores the console's current dimensions
	// resize console
	// MoveWindow(windows_handle, x, y, width, height, redraw_window);
	MoveWindow(console, r.left, r.top, 1500, 1050, TRUE);
	// end code to resize console window

	// initialize game board


	// construct first bunny
	vector<Bunny> bunnyList;

	vector<Bunny>::iterator it; // used to iterate through list
	int cnt = 0;

	Bunny *newBunny;

	for (int i = 0; i < 5; ++i)
	{
		newBunny = new Bunny;
		newBunny->numBunnies += 1;         // increase the count of bunnies

		if (i == 0)
		{
			newBunny->intializeGameboard(); // initialize game board on first new bunny
		}
		newBunny->setName( newBunny->getRandomName() );

		newBunny->setAge( newBunny->getRandomNum(0,9) );

		newBunny->setSex( newBunny->getRandomSex() );

		if ( convertToRMVB() )              // see if bunny converts to RMVB
			newBunny->setSex('X');          // if TRUE, set sex to X

		newBunny->assignCoordinates();
		newBunny->placeBunnyOnBoard();

		bunnyList.push_back(*newBunny);       // save new bunny address in list		

	}

	//newBunny = new Bunny;
	//newBunny->numBunnies += 1;

	//newBunny->setSex('M');
	//newBunny->printAllStats();

	//bunnyList.push_back(*newBunny); //save new bunny address in list

	printBunnyList(bunnyList);
	cout << endl;

	// end list iteration
	//it = bunnyList.begin();
	//it->printAllStats();
	//cout << "Now starting to test functions by passing 1 instance of Bunny." << endl;

	// test increase age of all bunnies then print list
	increaseAllAges(bunnyList);

	//cout << "Testing bunny age increase." << endl;

	//for (it = bunnyList.begin(); it != bunnyList.end(); ++it)
	//{
	//	it->increaseAge();
	//}
	//cout << endl;

	printBunnyList(bunnyList);

	it = bunnyList.begin();
	it->printGameBoard();

	// end of program

	cout << "Press any key to end...";
	cin.get();
	MoveWindow(console, r.left, r.top, r.right - r.left, r.bottom - r.top, TRUE);
	system("cls");
	cout << "NOW press any key to end... console should be correct size.";
	cin.get();

    return 0;
}

