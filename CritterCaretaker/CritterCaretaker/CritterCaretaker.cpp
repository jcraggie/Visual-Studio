// CritterCaretaker.cpp : Defines the entry point for the console application.
// from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// simulates caring for a virtual pet
//
// entered by JCR 2016-09-15
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class Critter
{
public:
	Critter(int hunger = 0, int boredom = 0);
	void Talk();
	void Eat(int food = 4);
	void Play(int fun = 4);
private:
	int m_Hunger;
	int m_Boredom;
	int GetMood() const;
	void PassTime(int time = 1);
};

// class constructor
Critter::Critter(int hunger, int boredom) :
	m_Hunger(hunger),
	m_Boredom(boredom)
{}

// class member function definition
inline int Critter::GetMood() const
{
	return(m_Hunger + m_Boredom);
}

// class member function definition
void Critter::PassTime(int time)
{
	m_Hunger += time;
	m_Boredom += time;
}

// class member function definition
void Critter::Talk()
{
	cout << "I'm a critter and I feel ";
	int mood = GetMood();

	if (mood > 15)
	{
		cout << "mad." << endl;
	}
	else if (mood > 10)
	{
		cout << "frustrated." << endl;
	}
	else if (mood > 5)
	{
		cout << "okay." << endl;
	}
	else
	{
		cout << "happy." << endl;
	}

	PassTime();
}

// class member function definition
void Critter::Eat(int food)
{
	cout << "Brrruppp." << endl;
	m_Hunger -= food;
	if (m_Hunger < 0)
	{
		m_Hunger = 0;
	}

	PassTime();
}

// class member function definition
void Critter::Play(int fun)
{
	cout << "Wheee!" << endl;
	m_Boredom -= fun;
	if (m_Boredom < 0)
	{
		m_Boredom = 0;
	}

	PassTime();
}

//main
int main()
{
	Critter crit;
	crit.Talk();

	int choice;

	do
	{
		cout << endl << "Critter Caretaker" << endl << endl;
		cout << "0 - Quit" << endl;
		cout << "1 - Listen to your critter" << endl;
		cout << "2 - Feed your critter" << endl;
		cout << "3 - Play with your critter" << endl << endl;

		cout << "Choice: ";
		cin >> choice;
		getchar(); // clears the ENTER from above

		switch (choice)
		{
		case 0:
			cout << "Good-bye." << endl;
			break;
		case 1:
			crit.Talk();
			break;
		case 2:
			crit.Eat();
			break;
		case 3:
			crit.Play();
			break;
		default:
			cout << endl << "Sorry, but " << choice << " isn't a valid choice." << endl;
		}
		
	} while (choice != 0);

	cout << endl << endl << "Press any key to exit.";
	getchar();

    return 0;
}

