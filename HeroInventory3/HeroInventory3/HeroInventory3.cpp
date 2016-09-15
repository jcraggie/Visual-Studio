// HeroInventory3.cpp : Defines the entry point for the console application.
// Hero's Inventory 3.0 from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// Demonstrates iterators

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>

using namespace std;


int main()
{
	vector<string> inventory;
	inventory.push_back("sword");
	inventory.push_back("armor");
	inventory.push_back("sheild");

	vector<string>::iterator myIterator;
	vector<string>::const_iterator iter;

	cout << "Your items: " << endl;

	for (iter = inventory.begin(); iter != inventory.end(); ++iter)
	{
		cout << *iter << endl;
	}

	cout << endl << "You trade in your sword for a battle axe.";
	myIterator = inventory.begin();
	*myIterator = "battle axe";
	cout << endl << "Your items:" << endl;
	for (iter = inventory.begin(); iter != inventory.end(); ++iter)
	{
		cout << *iter << endl;
	}

	cout << endl << "The item name '" << *myIterator << "' has ";
	cout << (*myIterator).size() << " letters in it." << endl;

	cout << endl << "The item name '" << *myIterator << "' has ";
	cout << myIterator->size() << " letters in it." << endl;

	cout << endl << "You recover a crossbow from a slain enemy.";
	inventory.insert(inventory.begin(), "crossbow");

	cout << endl << "Your items: " << endl;
	for (iter = inventory.begin(); iter != inventory.end(); ++iter)
	{
		cout << *iter << endl;
	}

	cout << endl << "Your armor is destroyed in a fierce battle.";
	inventory.erase((inventory.begin() + 2));
	cout << endl << "Your items: " << endl;
	for (iter = inventory.begin(); iter != inventory.end(); ++iter)
	{
		cout << *iter << endl;
	}

	cout << endl << "Press any key to exit." << endl;
	getchar();



    return 0;
}

