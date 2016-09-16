// CritterPrivate.cpp : Defines the entry point for the console application.
// from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// demonstrates setting member access levels
//
// entered by JCR 2016-09-15
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class Critter
{
public: // begin public section
	Critter(int hunger = 0);
	int GetHunger() const;
	void SetHunger(int hunger);
private: // begin private section
	int m_Hunger;
};

Critter::Critter(int hunger) :
	m_Hunger(hunger)
{
	cout << "A new critter has been born!" << endl;
}

int Critter::GetHunger() const
{
	return m_Hunger;
}

void Critter::SetHunger(int hunger)
{
	if (hunger < 0)
	{
		cout << "You can't set a critter's hunger to a negative number." << endl << endl;
	}
	else
	{
		m_Hunger = hunger;
	}
}

int main()
{
	Critter crit(5);
	// cout << crit.m_Hunger; // illegal, m_Hunger is private!
	cout << "Calling GetHunger(): " << crit.GetHunger() << endl << endl;

	cout << "Calling SetHunger() with -1." << endl;
	crit.SetHunger(-1);

	cout << "Calling SetHunger() with 9." << endl;
	crit.SetHunger(9);

	cout << "Calling GetHunger(): " << crit.GetHunger() << endl << endl;
	
	cout << "Press any key to end.";
	getchar();
	return 0;
}