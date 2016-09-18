// BunnyFarm.cpp : Defines the entry point for the console application.
//
// using concepts and ideas from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// 

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>

#include <time.h>

using namespace std;

class Bunny
{
public:
	Bunny(const string& name = "");
	string GetName() const;
	Bunny* GetNext() const;
	void SetNext(Bunny* next);

private:
	string m_Name;
	Bunny* m_pNext; // pointer to next bunny in the list
};

Bunny::Bunny(const string& name) : // constructor used to assign the name passed to the class to m_PetName
	m_Name(name),
	m_pNext(0)
{} // empty constructor body

string Bunny::GetName() const
{
	return m_Name;
}

Bunny* Bunny::GetNext() const
{
	return m_pNext;
}

void Bunny::SetNext(Bunny* next)
{
	m_pNext = next;
}


class BunnyFarm
{
	friend ostream& operator<<(ostream& os, const BunnyFarm& aBunnyFarm);

public:
	BunnyFarm();      // constructor
	~BunnyFarm();     // destructor
	void AddBunny();  // addBunny instantiates a Bunny object on the heap and adds it to the end of the list
	void DelBunny();  // delBunny removes the first Bunny object in the list
	void ClearFarm(); // clearFarm removes all the bunny objects from the farm list, freeing the allocated memory

private:
	Bunny* m_pHead; // pointer to a Bunny object which represents the first bunny in the list
	Bunny* m_pLast; // pointer to the last Bunny object in the list
};

// farm constructor
BunnyFarm::BunnyFarm() :
	m_pHead(0),
	m_pLast(0)
{}

// farm destructor
// calls clearFarm which removes all the bunny objects from the farm list, freeing the allocated memory
BunnyFarm::~BunnyFarm()
{
	ClearFarm();
}

// addBunny adds a player to the end of the list in the bunnyFarm
void BunnyFarm::AddBunny()
{
	// create a new bunny node
	//cout << "Please enter the name of the new bunny: ";
	int min = 0, max = 13;
	int rnd = min + (rand() % (int)(max - min + 1));
	string bunnyNames[14] =
	{
		{ "Thumper" },
		{ "Cottontail" },
		{ "Peter" },
		{ "Beatrix" },
		{ "Brer Rabbit" },
		{ "Trix" },
		{ "Payton" },
		{ "Jenny" },
		{ "Barbara" },
		{ "Tashi" },
		{ "Jason" },
		{ "Harry" },
		{ "Russell" },
		{ "Ryan" }
	};
	string name;
	
	
	name = bunnyNames[rnd];
	//cin >> name;
	Bunny* pNewBunny = new Bunny(name); // instantiate a new Bunny object on the heap, setting the object's pointer data member to 0 (null)

	// if list is empty, make head of list this new bunny
	if (m_pHead == 0)
	{
		m_pHead = pNewBunny; // since list was empty, the first (head) is the new bunny
		m_pLast = pNewBunny; // since list was empty, last is also the new bunny
	}

	// otherwise find the end of the list and add the player there
	else
	{
		Bunny* pIter = m_pLast;       // go to the last bunny
		m_pLast->SetNext(pNewBunny);  // set next to point to the new bunny. last becomes "next to last"
		m_pLast = pNewBunny;          // set last bunny to the new bunny
	}

}



// delBunny removes the bunny at the head of the list
void BunnyFarm::DelBunny()
{
	// test m_pHead. if it is 0, then the farm is empty
	if (m_pHead == 0)
	{
		cout << "The Bunny Farm is empty. No bunnies to remove!" << endl;
	}
	else // otherwise, the first bunny in the list is removed.
	{
		Bunny* pTemp = m_pHead;         // temp points to the first bunny in the list
		m_pHead = m_pHead->GetNext();   // sets m_pHead to the next bunny in the list
		delete pTemp;                   // destroys the Bunny object pointed to by pTemp
	}
}

// ClearFarm removes all the bunnies from the farm
void BunnyFarm::ClearFarm()
{
	while (m_pHead != 0)
	{
		DelBunny();
	}
}

// operator<<() function overloads the << operator so I can display a BunnyFarm objecct by sending it to cout
ostream& operator<<(ostream& os, const BunnyFarm& aBunnyFarm)
{
	Bunny* pIter = aBunnyFarm.m_pHead;

	os << endl << "Here's who is on the Bunny Farm:" << endl;

	if (pIter == 0) // if farm is empty send appropriate message
	{
		os << "The farm is empty!" << endl;
	}
	else // otherwise cycle through all the bunnies on the farm, creating an output stream os of all the names
	{
		while (pIter != 0)
		{
			os << pIter->GetName() << endl;
			pIter = pIter->GetNext();
		}
	}
	return os;
}

int getRandNum(int min, int max)
{
	return min + (rand() % (int)(max - min + 1));
}

string bunnyNames[14] =
{
	{ "Thumper"        },
	{ "Cottontail"     },
	{ "Peter"          },
	{ "Beatrix"        },
	{ "Brer Rabbit"    },
	{ "Trix"           },
	{ "Payton"         },
	{ "Jenny"          },
	{ "Barbara"        },
	{ "Tashi"          },
	{ "Jason"          },
	{ "Harry"          },
	{ "Russell"        },
	{ "Ryan"           }
};


int main()
{

	srand((unsigned)time(NULL)); // generate random seed each time the program runs

	BunnyFarm myBunnyFarm; // instantiates a new BunnyFarm
	int choice;

	do
	{
		cout << myBunnyFarm;
		cout << endl << "BUNNY FARM MENU" << endl;
		cout << "0 - Exit the program." << endl;
		cout << "1 - Add a bunny to the farm." << endl;
		cout << "2 - Delete a bunny from the farm." << endl;
		cout << "3 - Clear the bunny farm." << endl;
		cout << "9 - Add first 5 bunnies to farm." << endl;
		cout << endl;
		cout << "Enter your choice: ";
		cin >> choice;

		switch (choice)
		{
		case 0: cout << "Goodbye." << endl; break;
		case 1: myBunnyFarm.AddBunny(); break;
		case 2: myBunnyFarm.DelBunny();break;
		case 3: myBunnyFarm.ClearFarm(); break;
		default: cout << "That was not a valid choice." << endl;
		}
	} while (choice != 0);

	cout << endl << endl << "Press any key to end.";
	getchar();
	return 0;
}

