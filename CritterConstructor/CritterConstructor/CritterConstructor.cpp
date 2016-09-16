// CritterConstructor.cpp : Defines the entry point for the console application.
// from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// demonstrates constructors
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
	Critter(int hunger = 0); // constructor prototype
	void Greet();
};

Critter::Critter(int hunger) // constructor definition
{
	cout << "A new critter has been born!" << endl;
	m_Hunger = hunger;
}

void Critter::Greet()
{
	cout << "Hi, I'm a critter. My hunger level is " << m_Hunger << "." << endl;
}



int main()
{
	Critter crit(7);
	crit.Greet();

	cout << endl << endl << "Press any key to exit.";
	getchar();
	return 0;
}

