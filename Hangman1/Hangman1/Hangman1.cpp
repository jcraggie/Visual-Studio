// Hangman1.cpp : Defines the entry point for the console application.
// From Beginning C++ Through Game Programming 4th Edition by Michael Dawson
//
// Entered by JCR 2016-09-15
// demonstrates 

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
#include <ctime>
#include <cctype>

using namespace std;


int main()
{
	// initializing variables and constants
	// setup
	const int MAX_WRONG = 8; // max number of incorrect guesses allowed
	vector<string> words; // collection of possible words to guess
	words.push_back("GUESS");
	words.push_back("HANGMAN");
	words.push_back("DIFFICULT");

	srand(static_cast<unsigned int>(time(0)));

	random_shuffle(words.begin(), words.end());

	const string THE_WORD = words[0]; //word to guess
	int wrong = 0; // number of incorrect guesses
	string soFar(THE_WORD.size(), '-'); // word guessed so far
	string used = ""; //letters already guessed

	cout << "Welcome to Hangman. Good luck!" << endl;

	//main loop
	while ((wrong < MAX_WRONG) && (soFar != THE_WORD))
	{
		cout << endl << "You have " << (MAX_WRONG - wrong);
		cout << " incorrect guesses left." << endl;
		cout << endl << "You've used the following letteres: " << endl << used << endl;
		cout << endl << "So far, the word is: " << endl << soFar << endl;


		// get the player's guess
		char guess;
		cout << endl << endl << "Enter your guess: ";
		cin >> guess;
		getchar(); // is this needed to clear the RETURN from guess?
		guess = toupper(guess); // make uppercase since secret word is in uppercase
		while (used.find(guess) != string::npos)
		{
			cout << endl << "You've already guessed " << guess << endl;
			cout << "Enter your guess: ";
			cin >> guess;
			getchar(); // is this needed to clear the RETURN from guess?
			guess = toupper(guess);
		}
		used += guess; //adds the letter to the used list

		if (THE_WORD.find(guess) != string::npos)
		{
			cout << "That's right! " << guess << " is in the word. " << endl;

			// update soFar to include newly guessed letter
			for (int i = 0; i < THE_WORD.length(); ++i)
			{
				if (THE_WORD[i] == guess)
				{
					soFar[i] = guess;
				}
			}
		}
		else
		{
			cout << "Sorry, " << guess << " isn't in the word." << endl;
			++wrong;
		}
	}

	// ending the game
	// shut down
	if (wrong == MAX_WRONG)
	{
		cout << endl << "You've been hanged!";
	}
	else
	{
		cout << endl << "You guessed it!";
	}

	cout << endl << "The word was " << THE_WORD << endl;

	cout << endl << endl << "Press any key to end the program.";
	getchar();


    return 0;
}

