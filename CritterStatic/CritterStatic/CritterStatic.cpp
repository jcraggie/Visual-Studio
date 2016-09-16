// CritterStatic.cpp : Defines the entry point for the console application.
// from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// demonstrates static member variables and functions
//
// entered by JCR 2016-09-15
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class Critter
{
public:
	static int s_Total; // static member var declaration - total number of Critter objects in existence
	Critter(int hunger = 0);
	static int GetTotal(); // static member function prototype
private:
	int m_Hunger;
};

int Critter::s_Total = 0; // static member variable initialization

Critter::Critter(int hunger) :
	m_Hunger(hunger)
{
	cout << "A critter has been born!" << endl;
	++s_Total;
}

int Critter::GetTotal() // static member function definition
{
	return s_Total;
}

int main()
{
	cout << "The total number of critters is: ";
	cout << Critter::s_Total << endl << endl;

	Critter crit1, crit2, crit3;

	cout << endl << "The total number of critters is: ";
	cout << Critter::GetTotal() << endl;

	cout << endl << endl << "Press any key to end.";
	getchar();

    return 0;
}

