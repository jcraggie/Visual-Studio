// HelloRyan.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <string>

using namespace std;


int main()

{
	cout << "Hello Ryan." << endl;
	cout << "How are you today? : ";
	string feeling;
	cin >> feeling;
	getchar();
	cout << "I'm glad you're feeling " << feeling << endl;

	cout << "Press any key to end.";
	getchar();


    return 0;
}

