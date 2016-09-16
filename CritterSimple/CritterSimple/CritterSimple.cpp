// CritterSimple.cpp : Defines the entry point for the console application.
// from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
//
// entered by JCR 2016-09-15
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class Critter
{
public:
	int m_Hunger;
	void Greet();
};

void Critter::Greet()
{
	cout << "Hi, I'm a critter. My hunger level is " << m_Hunger << "." << endl;
}



int main()
{
	Critter crit1;
	Critter crit2;

	crit1.m_Hunger = 9;
	cout << "crit1's hunger level is " << crit1.m_Hunger << "." << endl;

	crit2.m_Hunger = 3;
	cout << "crit2's hunger level is " << crit2.m_Hunger << "." << endl;

	crit1.Greet();
	crit2.Greet();

	cout << endl << endl << "Press any key to exit.";
	getchar();
    return 0;
}

