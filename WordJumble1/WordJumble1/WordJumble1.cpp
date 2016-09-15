// WordJumble1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>

using namespace std;


int main()
{
	enum fields { WORD, HINT, NUM_FIELDS };
	const int NUM_WORDS = 5;
	const string WORDS[NUM_WORDS][NUM_FIELDS] =
	{
		{"wall","Do you feel you're banking your head against something?"},
		{"glasses","These might help you see the answser."},
		{"labored","Going slowly, is it?"},
		{"persistent","Kepp at it."},
		{"jumble","It's what the game is all about."}
	};

	srand(static_cast<unsigned int>(time(0)));

	int choice = (rand() % NUM_WORDS);
	string theWord = WORDS[choice][WORD]; // word to guess
	string theHint = WORDS[choice][HINT]; // hint for word

	// time to jumble the word
	string jumble = theWord; // jumbled version of the word

	int length = jumble.size();

	for (int i = 0; i < length; ++i)
	{
		int index1 = (rand() % length);
		int index2 = (rand() % length);
		char temp = jumble[index1];
		jumble[index1] = jumble[index2];
		jumble[index2] = temp;
	}

	// welcome the player
	cout << "\t\t\tWelcome to Word Jumble!" << endl << endl;
	cout << "Unscramble the letters to make a word." << endl;
	cout << "Enter 'hint' for a hint." << endl;
	cout << "Enter 'quit' to quit the game." << endl << endl;
	cout << "The jumble is: " << jumble;

	string guess;
	cout << endl << endl << "Your guess: ";
	cin >> guess;

	// enter the game loop
	while ((guess != theWord) && (guess != "quit"))
	{
		if (guess == "hint")
		{
			cout << theHint;
		}
		else
		{
			cout << "Sorry, that's not it.";
		}

		cout << endl << endl << "Your guess: ";
		cin >> guess;
	}

	// saying goodbye
	if (guess == theWord)
	{
		cout << endl << "That's it! You guess it!" << endl;
	}

	cout << endl << "Thanks for playing." << endl;

	getchar();
	getchar();

	return 0;
}

