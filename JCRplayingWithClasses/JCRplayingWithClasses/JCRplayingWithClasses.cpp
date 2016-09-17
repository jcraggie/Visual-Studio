// JCRplayingWithClasses.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <vector>

using namespace std;

class Pets
{
public:
	Pets(const string& name = "");
	string getPetName() const;
	static int s_NumPets;
	static int getNumPets();

private:
	string m_PetName;
};

Pets::Pets(const string& name) : // constructor used to assign the name passed to the class to m_PetName
	m_PetName(name)
{} // empty constructor body




int main()
{
    return 0;
}

