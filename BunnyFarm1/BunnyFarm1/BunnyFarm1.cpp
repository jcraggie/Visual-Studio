// BunnyFarm1.cpp : Defines the entry point for the console application.
// just testing using classes for bunnies. this is going to be the beginning of the bunny farm program.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Bunny
{
public:
	Bunny(const string& name = "");
	string getName() const;

private:
	string m_Name;
};

Bunny::Bunny(const string& name) : // constructor used to assign the name passed to the class to m_PetName
	m_Name(name)
{} // empty constructor body

inline string Bunny::getName() const
{
	return m_Name;
}

class BunnyFarm
{
public:
	BunnyFarm(int spaces = 1); // default number of spaces for Bunnies
	void Add(const Bunny& aBunny);
	void ListBunnies() const;
	
private:
	vector<Bunny> m_Bunnies;
};

BunnyFarm::BunnyFarm(int spaces)
{
	m_Bunnies.reserve(spaces);
}

void BunnyFarm::Add(const Bunny& aBunny)
{
	m_Bunnies.push_back(aBunny);
}

void BunnyFarm::ListBunnies() const
{
	for (vector<Bunny>::const_iterator iter = m_Bunnies.begin(); iter != m_Bunnies.end(); ++iter)
	{
		cout << iter->getName() << " here." << endl;
	}
}


int main()
{
	Bunny bun("Tashi");
	cout << "My first bunny's name is " << bun.getName() << endl;

	cout << endl << "Creating Bunny Farm now." << endl;
	BunnyFarm myBunnyFarm(3);

	cout << endl << "Adding three bunnies to the farm." << endl;
	myBunnyFarm.Add(Bunny("Jenny"));
	myBunnyFarm.Add(Bunny("Peter"));
	myBunnyFarm.Add(Bunny("Trix"));

	cout << endl << "Listing bunnies in the farm: " << endl;
	myBunnyFarm.ListBunnies();

	cout << endl << endl << "Press any key to end.";
	getchar();
	return 0;
}

