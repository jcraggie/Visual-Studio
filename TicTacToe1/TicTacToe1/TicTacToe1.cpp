// TicTacToe1.cpp : Defines the entry point for the console application.
// from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
//
// entered by JCR 2016-09-15
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

// GLOBAL CONSTANTS
const char X = 'X';
const char O = 'O';
const char EMPTY = ' ';
const char TIE = 'T';
const char NO_ONE = 'N';

// function prototypes
void instructions();
char askYesNo(string quesetion);
int askNumber(string question, int high, int low = 0);
char humanPiece();
char opponent(char piece);
void displayBoard(const vector<char>& board);
char winner(const vector<char>& board);
bool isLegal(const vector<char>& board, int move);
int humanMove(const vector<char>& board, char human);
int computerMove(vector<char> board, char computer);
void announceWinner(char winner, char computer, char human);

// main function
int main()
{
	int move;
	const int NUM_SQUARES = 9;
	vector<char> board(NUM_SQUARES, EMPTY);

	instructions();
	char human = humanPiece();
	char computer = opponent(human);
	char turn = X;

	displayBoard(board);

	while (winner(board) == NO_ONE)
	{
		if (turn == human)
		{
			move = humanMove(board, human);
			board[move] = human;
		}
		else
		{
			move = computerMove(board, computer);
			board[move] = computer;
		}

		displayBoard(board);
		turn = opponent(turn);
	}

	announceWinner(winner(board), computer, human);

	cout << endl << endl << "Press any key to exit.";
	getchar();

    return 0;
}

// instructions
void instructions()
{
	cout << "Welcome to the ultimate man-machine showdown: Tic-Tac-Toe.\n";
	cout << "--where human brain is pit against silicon processor\n\n";

	cout << "Make your move known by entering a number, 0 - 8.  The number\n";
	cout << "corresponds to the desired board position, as illustrated:\n\n";

	cout << "       0 | 1 | 2\n";
	cout << "       ---------\n";
	cout << "       3 | 4 | 5\n";
	cout << "       ---------\n";
	cout << "       6 | 7 | 8\n\n";

	cout << "Prepare yourself, human.  The battle is about to begin.\n\n";
}

// asks Yes or No and return y or n
char askYesNo(string question)
{
	char response;
	do
	{
		cout << question << " (y/n): ";
		cin >> response;
		getchar(); // clears the ENTER from above - added by JCR
	} while (response != 'y' && response != 'n');

	return response;
}

// asks for a number within a range
int askNumber(string question, int high, int low)
{
	int number;
	do
	{
		cout << question << " (" << low << " - " << high << ") : ";
		cin >> number;
		getchar(); // clears the ENTER from above - added by JCR
	} while (number > high || number < low);

	return number;
}

// humanPiece - asks if the human wants to go first and return the piece, X or O, based on that answer.
// tradition is X goes first
char humanPiece()
{
	char go_first = askYesNo("Do you require the first move?");
	if (go_first == 'y')
	{
		cout << endl << "Then take the first move. You will need it." << endl;
		return X;
	}
	else
	{
		cout << endl << "Your bravery will be your undoing... I will go first." << endl;
		return O;
	}
}

// opponent - returns the opponent's piece, X or O
char opponent(char piece)
{
	if (piece == X)
	{
		return O;
	}
	else
	{
		return X;
	}
}
// display the game board
void displayBoard(const vector<char>& board)
{
	cout << "\n\t" << board[0] << " | " << board[1] << " | " << board[2];
	cout << "\n\t" << "---------";
	cout << "\n\t" << board[3] << " | " << board[4] << " | " << board[5];
	cout << "\n\t" << "---------";
	cout << "\n\t" << board[6] << " | " << board[7] << " | " << board[8];
	cout << "\n\n";
}

char winner(const vector<char>& board)
{
	// all possible winning rows
	const int WINNING_ROWS[8][3] = { { 0, 1, 2 },
	{ 3, 4, 5 },
	{ 6, 7, 8 },
	{ 0, 3, 6 },
	{ 1, 4, 7 },
	{ 2, 5, 8 },
	{ 0, 4, 8 },
	{ 2, 4, 6 } };
	const int TOTAL_ROWS = 8;

	// if any winning row has three values that are the same (and not EMPTY),
	// then we have a winner
	for (int row = 0; row < TOTAL_ROWS; ++row)
	{
		if ((board[WINNING_ROWS[row][0]] != EMPTY) &&
			(board[WINNING_ROWS[row][0]] == board[WINNING_ROWS[row][1]]) &&
			(board[WINNING_ROWS[row][1]] == board[WINNING_ROWS[row][2]]))
		{
			return board[WINNING_ROWS[row][0]];
		}
	}

	// since nobody has won, check for a tie (no empty squares left)
	if (count(board.begin(), board.end(), EMPTY) == 0)
		return TIE;

	// since nobody has won and it isn't a tie, the game ain't over
	return NO_ONE;
}

inline bool isLegal(int move, const vector<char>& board)
{
	return (board[move] == EMPTY);
}

int humanMove(const vector<char>& board, char human)
{
	int move = askNumber("Where will you move?", (board.size() - 1));
	while (!isLegal(move, board))
	{
		cout << "\nThat square is already occupied, foolish human.\n";
		move = askNumber("Where will you move?", (board.size() - 1));
	}
	cout << "Fine...\n";

	return move;
}

int computerMove(vector<char> board, char computer)
{
	unsigned int move = 0;
	bool found = false;

	//if computer can win on next move, that�s the move to make
	while (!found && move < board.size())
	{
		if (isLegal(move, board))
		{
			//try move
			board[move] = computer;
			//test for winner
			found = winner(board) == computer;
			//undo move
			board[move] = EMPTY;
		}

		if (!found)
		{
			++move;
		}
	}

	//otherwise, if opponent can win on next move, that's the move to make
	if (!found)
	{
		move = 0;
		char human = opponent(computer);

		while (!found && move < board.size())
		{
			if (isLegal(move, board))
			{
				//try move
				board[move] = human;
				//test for winner
				found = winner(board) == human;
				//undo move
				board[move] = EMPTY;
			}

			if (!found)
			{
				++move;
			}
		}
	}

	//otherwise, moving to the best open square is the move to make
	if (!found)
	{
		move = 0;
		unsigned int i = 0;

		const int BEST_MOVES[] = { 4, 0, 2, 6, 8, 1, 3, 5, 7 };
		//pick best open square
		while (!found && i <  board.size())
		{
			move = BEST_MOVES[i];
			if (isLegal(move, board))
			{
				found = true;
			}

			++i;
		}
	}

	cout << "I shall take square number " << move << endl;
	return move;
}

void announceWinner(char winner, char computer, char human)
{
	if (winner == computer)
	{
		cout << winner << "'s won!\n";
		cout << "As I predicted, human, I am triumphant once more -- proof\n";
		cout << "that computers are superior to humans in all regards.\n";
	}

	else if (winner == human)
	{
		cout << winner << "'s won!\n";
		cout << "No, no!  It cannot be!  Somehow you tricked me, human.\n";
		cout << "But never again!  I, the computer, so swear it!\n";
	}

	else
	{
		cout << "It's a tie.\n";
		cout << "You were most lucky, human, and somehow managed to tie me.\n";
		cout << "Celebrate... for this is the best you will ever achieve.\n";
	}
}