// Bunnies.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <time.h> // used for random number generator
#include "Bunny.h" // created by JCR
#define _WIN32_WINNT 0x0500
#include <Windows.h>
using namespace std;

int getRandomNum(int min, int max)
{
	return min + (rand() % (int)(max - min + 1));
}

char getRandomSex()
{
	//vector<Bunny>::iterator it;
	int min, max;
	int sexNum; // 0 or 1
	
	min = 0; // (F)emale
	max = 1; // (M)ale

	sexNum = getRandomNum(min, max);

	if (sexNum == 0)
		return 'F';
	else 
		return 'M';
}



bool convertToRMVB()
{
	int const RMVB_PERCENT = 2;
	
	// should only return TRUE RMVB_PERCENT of the time
	return(rand() % 100) < RMVB_PERCENT;
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



	// construct first bunny
	//Bunny bunny;
	vector<Bunny> bunnyList;
	int cnt = 0;

	Bunny *newBunny;

	for (int i = 0; i < 5; ++i)
	{
		newBunny = new Bunny;
		newBunny->numBunnies += 1;

		newBunny->setAge(getRandomNum(0, 9));
		newBunny->setSex(getRandomSex());
		if (newBunny->getAge() < 2)
		{
			if (newBunny->getSex() == 'F')
				newBunny->setSex('f');
			else
				newBunny->setSex('m');
		}
		if ( convertToRMVB() )              // see if bunny converts to RMVB
			newBunny->setSex('X');          // if TRUE, set sex to X



		bunnyList.push_back(*newBunny);       // save new bunny address in list		

	}

	//newBunny = new Bunny;
	//newBunny->numBunnies += 1;

	//newBunny->setSex('M');
	//newBunny->printAllStats();

	//bunnyList.push_back(*newBunny); //save new bunny address in list

	vector<Bunny>::iterator it; // used to iterate through list

	for (it = bunnyList.begin(); it != bunnyList.end(); ++it)
	{
		it->printBunny();
	}

	// end list iteration
	it = bunnyList.begin();
	it->printAllStats();
	cout << "Now starting to test functions by passing 1 instance of Bunny." << endl;

	// test increase age of all bunnies then print list
	for (it = bunnyList.begin(); it != bunnyList.end(); ++it)
	{
		it->increaseAge();
		it->printBunny();
	}
	cout << endl;



	// end of program

	cout << "Press any key to end...";
	cin.get();
	MoveWindow(console, r.left, r.top, r.right - r.left, r.bottom - r.top, TRUE);
	system("cls");
	cout << "NOW press any key to end... console should be correct size.";
	cin.get();

    return 0;
}

