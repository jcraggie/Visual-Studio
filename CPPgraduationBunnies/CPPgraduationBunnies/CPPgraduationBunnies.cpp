// 2016-08-28 05:43 working on checkForBunniesNextToRMVB
// appears to get stuck in a loop when it finds a bunny to change, but does not change it.


// CPPgraduationBunnies.cpp : Defines the entry point for the console application.
//

// INTIALIZATION
// generate blank 80 x 80 grid and fill with '.' which represents an empty space
// generate 5 bunnies with random names, sex, age, rmvb, row, col
// 

// ENHANCEMENT IDEAS
// make Name assignment dependent on sex of bunny. If born mutant, any name works



#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <time.h>
#include <Windows.h>
#include <iomanip>


// DEFINE CONSTANTS
#define MAX_NAMES         14
#define MAX_COLORS         4
#define MAX_START_BUNNIES  5
#define MAX_BOARD_ROWS    80
#define MAX_BOARD_COLUMS  80
#define RMVB_PERCENT       2
#define MAX_AGE_ADULTS    10
#define MAX_AGE_RMVB      30
#define OUTPUT_COL        90

using namespace std;

int getRandNum(int min, int max)
{
	return min + (rand() % (int)(max - min + 1));
}

void initializeBoard(char b[MAX_BOARD_ROWS][MAX_BOARD_COLUMS])
{
	int r, c;

	for (r = 0; r < MAX_BOARD_ROWS; ++r)
		for (c = 0; c < MAX_BOARD_COLUMS; ++c)
			b[r][c] = '.';
}





struct bunny
{
	char           name[15];    // determined from a pre-defined list of names listOfNames
	int            age;         // 0-10 ages 1 year with each turn / dies at 10 years unless rmvb, which die at age 50
	char           sex;         // ADULT (M)ale (F)emale OR JUVENILE (m)ale (f)emale OR (X) indicates rmvb and does not breed
	int            colorNum;    // colors 0 - maximum number of colors
	char           color[15];   // white, brown, black, spotted
	bool           rmvb;        // radioactive_mutant_vampire_bunny true / false
	int            row;         // row coord of bunny on 80 x 80 grid
	int            col;         // col coord of bunny on 80 x 80 grid
	struct bunny   *next;       // points to next bunny in the list
};

struct indexes
{
	struct bunny   *root;
	struct bunny   *first;
	struct bunny   *last;
	struct bunny   *current;   // used to pass the address of the current bunny being worked with
	struct bunny   *mom;       // used to pass address of the mother bunny giving birth to baby - need this for mom's coords
	int             outputRow; // in Gotoxy, row is Y
	int             outputCol; // in Gotoxy, col is X
	char            board[MAX_BOARD_ROWS][MAX_BOARD_COLUMS];
};


struct bStats
{
	int              numAdultMales;
	int              numAdultFemales;
	int              numJuvMales;
	int              numJuvFemales;
	int              numMales;
	int              numFemales;
	int              numBirths;
	int              numDeaths;
	int              numRMVB;
	int              totalBunnies;
	int              numTurns;
};

void initializeIdxBoard(indexes *idx)
{
	int r, c;

	for (r = 0; r < MAX_BOARD_ROWS; ++r)
		for (c = 0; c < MAX_BOARD_COLUMS; ++c)
			idx->board[r][c] = '.';
}


void initializeStats(bStats *stats)
{
	stats->numAdultMales = 0;
	stats->numAdultFemales = 0;
	stats->numJuvMales = 0;
	stats->numJuvFemales = 0;
	stats->numMales = 0;
	stats->numFemales = 0;
	stats->numRMVB = 0;
	stats->totalBunnies = 0;
	stats->numBirths = 0;
	stats->numDeaths = 0;
	stats->numTurns = 0;
}

struct bNames
{
	char bName[15];
};

struct bColors
{
	char bColor[15];
};

const struct bNames bunnyNames[14] =
{
	{"Thumper       "},
	{"Cottontail    "},
	{"Peter         "},
	{"Beatrix       "},
	{"Brer Rabbit   "},
	{"Trix          "},
	{"Jack          "},
	{"Jenny         "},
	{"Barbara       "},
	{"Tashi         "},
	{"Jason         "},
	{"Harry         "},
	{"Russell       "},
	{"Jessica       "}
};

const struct bColors bunnyColors[4] =
{
	{"white         "},
	{"brown         "},
	{"black         "},
	{"spotted       "}
};

void createRoot(indexes *idx)
{
	idx->root = new bunny; // create ROOT record at head of the list. This record will not change and be named ROOT
	idx->root->next = NULL; // NULL incdiates this is the end of the list
	strcpy_s(idx->root->name,"ROOT");
	idx->root->age = 0;
	idx->root->sex = 'R'; // setting this to R so it won't get calculated in stats
	idx->root->row = 0;
	idx->root->col = 0;
	idx->root->colorNum = 2;
	strcpy_s(idx->root->color, bunnyColors[2].bColor);
	idx->root->rmvb = 0;

}

void updateLastBunny(indexes *idx)
{
	bunny *conductor;
	conductor = idx->root;

	if (conductor != 0)
	{
		while (conductor->next != 0)
			conductor = conductor->next;
	}
	idx->last = conductor;

}

char getRandomSex()
{
	int min, max;
	int sex_num;

	min = 0; // (F)emale
	max = 1; // (M)ale

	sex_num = getRandNum(min, max);

	if (sex_num == 0)
		return 'F';
	else if (sex_num == 1)
		return 'M';
	else
		return 'Z';

}


int getRandomName()
{
	int min, max;
	
	min = 0;
	max = MAX_NAMES;
	

	return min + (rand() % (int)(max - min + 1));

}

bool isRMVB()
{
	return (rand() % 100) < RMVB_PERCENT; // should return true only RMVB_PERCENT of the time
}

void placeBunnyOnBoard(indexes *idx, char marker)
{
	int r, c; 
	
	void Gotoxy(int x, int y);

	//bunny *current;
	r = idx->current->row;
	c = idx->current->col;

	//while (idx->board[r][c] != '.')
	//{
	//	r = getRandNum(0, MAX_BOARD_ROWS-1);
	//	c = getRandNum(0, MAX_BOARD_COLUMS-1);
	//}
	
	// save coords assinged to bunny's info
	idx->current->row = r;
	idx->current->col = c;

	// place the marker on the board. marker is the sex of the bunny for now
	idx->board[r][c] = marker; // THIS IS A GOOD PLACE FOR BREAKPOINT DURING DEBUGGING
	//Gotoxy(idx->outputCol, idx->outputRow);
	//cout << "Place: " << setw(3) << r << ","<< setw(3) << c;

	//idx->outputRow += 1;
	Gotoxy(c, r);
	cout << marker;

}

void placeRandomBunnyOnBoard(indexes *idx, char marker)
{
	int r, c;

	void Gotoxy(int x, int y);

	//bunny *current;

	r = getRandNum(0, MAX_BOARD_ROWS-1);
	c = getRandNum(0, MAX_BOARD_COLUMS-1);

	while (idx->board[r][c] != '.')
	{
		r = getRandNum(0, MAX_BOARD_ROWS - 1);
		c = getRandNum(0, MAX_BOARD_COLUMS - 1);
	}

	// save coords assinged to bunny's info
	idx->current->row = r;
	idx->current->col = c;

	idx->board[r][c] = marker; // saves marker (sex) to board array
	Gotoxy(c, r);
	cout << marker; // places the marker on the console screen 

}




void initializeFirstBunnies(indexes *idx, bStats *stats)
{
	void updateStats(indexes *idx, bStats *stats);
	
	int i;
	//int r, c; // used for row and column assignments
	int num; // used for random numbers when assigning values to bunny
	bunny *conductor; // use this to naviate through the list
	//bunny *current; // use this to save address of bunny being worked with
	bool isJuv = false;
	bool isAdult = false;
	bool isMale = false;
	bool isFemale = false;
	bool isaRMVB = false;
	//initialize color counters in the future here

	conductor = idx->first;

	idx->last = idx->first; // now last point to the first bunny since it is the only bunny


	for (i = 0; i < MAX_START_BUNNIES; ++i)
	{
		isJuv = false;
		isAdult = false;
		isMale = false;
		isFemale = false;
		isaRMVB = false;

		conductor->next = new bunny;
		conductor = conductor->next;
		conductor->next = NULL;	

		idx->current = conductor;  // saves address of this bunny as current
		if (i == 0)
		{
			idx->first = conductor;
			idx->last = conductor;
		}

		if (i == MAX_START_BUNNIES - 1)
		{
			idx->last = conductor;
		}

		conductor->age = getRandNum(0, 9);  // random age between 0 and 9 (10 is dead) (50 is max for rmvb's)
		if (conductor->age < 2)
			isJuv = true;
		else
			isAdult = true;
		
		conductor->sex = getRandomSex();
		if (conductor->sex == 'M')
		{
			isMale = true;
			if (conductor->age < 2)
				conductor->sex = 'm';
		}
		if (conductor->sex == 'F')
		{
			isFemale = true;
			if (conductor->age < 2)
				conductor->sex = 'f';

		}

		conductor->rmvb = isRMVB(); // return 1 if yes, 0 if no
		if (conductor->rmvb)
		{
			isaRMVB = true;
			isMale = false;
			isFemale = false;
			conductor->sex = 'X';
		}




		num = getRandNum(0,MAX_NAMES-1);
		strcpy_s(conductor->name, bunnyNames[num].bName);

		num = getRandNum(0, MAX_COLORS - 1);
		conductor->colorNum = num;
		strcpy_s(conductor->color, bunnyColors[num].bColor);
		// bool for color counters go here in the future


		placeRandomBunnyOnBoard(idx, conductor->sex);  // replaces above code to put the bunny on the board

		// update counts below
		updateStats(idx, stats);

	}
	idx->last = conductor;
	
}



void giveBirth(indexes *idx, bStats *stats, int colorOfMom)
{
	void printBunnies(indexes *idx);
	void printCurrentBunny(indexes *idx);
	bool checkNewCoords(indexes *idx, int babyRow, int babyCol);
	void Gotoxy(int x, int y);

	int num; // used for random numbers when assigning values to bunny
	int directionOfBirth; // used to determine which directon from mom to try and give birth. 0-3 = up, down, left, right
	bunny *conductor; // use this to naviate through the list
	bunny *newBaby;   // use this to clarify new baby below
	bool isJuv = false;
	bool isAdult = false;
	bool isMale = false;
	bool isFemale = false;
	bool isaRMVB = false;
	int babyRow, babyCol;  // used to determine where to give birth to baby... has to be next to mom

	// bools below used to determine if bunny has space around it to give birth
	bool triedUp = false, triedDown = false, triedLeft = false, triedRight = false;
	bool triedAllDirections = false, canGiveBirth = true;

	//initialize color counters in the future here


	do
	{
		babyRow = idx->mom->row;
		babyCol = idx->mom->col;
		directionOfBirth = getRandNum(0, 3);
		switch (directionOfBirth)
		{
		case 0:
			triedUp = true;
			babyRow -= 1;
			break;
		case 1:
			triedDown = true;
			babyRow += 1;
			break;
		case 2:
			triedLeft = true;
			babyCol -= 1;
			break;
		case 3:
			babyCol += 1;
			triedRight = true;
			break;
		default:
			break;
		}
		if (triedUp && triedDown && triedLeft && triedRight)
		{
			//Gotoxy(idx->outputCol, idx->outputRow);
			//cout << "Tried all directions.";
			//idx->outputRow += 1;
			triedAllDirections = true;
			canGiveBirth = false;
			break;
		}


	} while (!checkNewCoords(idx, babyRow, babyCol) && !triedAllDirections);

	if (!canGiveBirth)
		return;








	
	// get to end of the list where new bunny will be inserted
	conductor = idx->root;
	while (conductor->next != NULL)
		conductor = conductor->next;
	idx->last = conductor;

	conductor = idx->last;
	// create new bunny	
	stats->numBirths += 1;
	conductor->next = new bunny;
	conductor = conductor->next;
	conductor->next = NULL;
	idx->last = conductor; // update last bunny to new one just made
	idx->current = conductor;
	
	newBaby = conductor;
	//babyRow = idx->mom->row;
	//babyCol = idx->mom->col;

	newBaby->sex = getRandomSex();

	if (newBaby->sex == 'M')
	{
		isMale = true;
		newBaby->sex = 'm';
	}
	if (newBaby->sex == 'F')
	{
		isFemale = true;
		newBaby->sex = 'f';
	}

	newBaby->rmvb = isRMVB();
	if (newBaby->rmvb)
	{
		isaRMVB = true;
		newBaby->sex = 'X';
		isMale = false;
		isFemale = false;
	}
	newBaby->age = 0;

	num = getRandNum(0, MAX_NAMES - 1);
	strcpy_s(newBaby->name, bunnyNames[num].bName);

	newBaby->colorNum = colorOfMom;
	strcpy_s(newBaby->color, bunnyColors[colorOfMom].bColor);
	

	//



	if (canGiveBirth)
	{
		Gotoxy(idx->outputCol, idx->outputRow);
		cout << "Birth to " << newBaby->name << babyRow << "," << babyCol;
		idx->outputRow += 1;

		newBaby->row = babyRow;
		newBaby->col = babyCol;
		idx->current = newBaby;
		printCurrentBunny(idx);
		placeBunnyOnBoard(idx, newBaby->sex);
	}
	//else
	//{
	//	Gotoxy(idx->outputCol, idx->outputRow);
	//	cout << "Can't give birth. " << babyRow << "," << babyCol;
	//	idx->outputRow += 1;
	//}

}

void printStatsColumn(indexes *idx, bStats *stats)
{
	void Gotoxy(int x, int y);

	Gotoxy(0, 0);

	int r, c;
	r = idx->outputRow;
	c = idx->outputCol;

	Gotoxy(c, r); cout << "---------------------     "; r++;
	Gotoxy(c, r); cout << "  BUNNY STATISTICS        "; r++;
	Gotoxy(c, r); cout << "---------------------     "; r++;
	Gotoxy(c, r); cout << "      Total Males: " << stats->numMales; r++;
	Gotoxy(c, r); cout << "    Total Females: " << stats->numFemales; r++;
	Gotoxy(c, r); cout << "             RMVB: " << stats->numRMVB; r++;
	Gotoxy(c, r); cout << "    Total Bunnies: " << stats->totalBunnies; r++;
	Gotoxy(c, r); cout << "                           "; r++;
	Gotoxy(c, r); cout << "      Adult Males: " << stats->numAdultMales; r++;
	Gotoxy(c, r); cout << "    Adult Females: " << stats->numAdultFemales; r++;
	Gotoxy(c, r); cout << "                          "; r++;
	Gotoxy(c, r); cout << "   Juvenlie Males: " << stats->numJuvMales; r++;
	Gotoxy(c, r); cout << " Juvenile Females: " << stats->numJuvFemales; r++;
	Gotoxy(c, r); cout << "                           "; r++;
	Gotoxy(c, r); cout << "           Births: " << stats->numBirths; r++;
	Gotoxy(c, r); cout << "           Deaths: " << stats->numDeaths; r++;
	Gotoxy(c, r); cout << "                           "; r++;
	Gotoxy(c, r); cout << "Total turns taken: " << stats->numTurns; r++;
	Gotoxy(c, r); cout << "---------------------       "; r++;
	Gotoxy(c, r); cout << "                            "; r++;

	idx->outputRow = r;
}



void printStats(bStats *stats)
{
	cout << "-----------------------------------------------------------------------------------------\n";
	cout << "  BUNNY STATISTICS AS OF TURN " << stats->numTurns << "                                     Total Bunnies: " << stats->totalBunnies << endl;
	cout << "-----------------------------------------------------------------------------------------\n";
	cout << "   Juvenlie Males: " << stats->numJuvMales << "    Juvenile Females: " << stats->numJuvFemales << "          RMVB: " << stats->numRMVB << endl;
	cout << "      Adult Males: " << stats->numAdultMales << "       Adult Females: " << stats->numAdultFemales << endl;
	cout << "      Total Males: " << stats->numMales << "       Total Females: " << stats->numFemales << endl;
	cout << "\n";
	cout << "           Births: " << stats->numBirths << endl;
	cout << "           Deaths: " << stats->numDeaths << endl;
	cout << "-----------------------------------------------------------------------------------------\n";
	cout << "\n";
}



void printBunnies(indexes *idx)
{
	void Gotoxy(int x, int y);
	bunny *conductor;
	
	conductor = idx->first;

	Gotoxy(idx->outputCol, idx->outputRow); cout << "----------------------\n"; idx->outputRow += 1;
	Gotoxy(idx->outputCol, idx->outputRow); cout << "CURRENT BUNNY LIST\n"; idx->outputRow += 1;
	Gotoxy(idx->outputCol, idx->outputRow); cout << "----------------------\n"; idx->outputRow += 1;
	while (conductor != NULL)
	{
		Gotoxy(idx->outputCol, idx->outputRow); cout << "  Name: " << conductor->name;
		//cout << "   Sex: " << conductor->sex;
		//cout << " Color: " << conductor->color;
		cout << "   Age: " << conductor->age;
		//cout << "  RMVB: " << conductor->rmvb ? "** YES **" : "no";
		cout << " Coords: " << conductor->row << "," << conductor->col; idx->outputRow += 1;

		conductor = conductor->next;
	}
}

void printCurrentBunny(indexes *idx)
{
	void Gotoxy(int x, int y);
	bunny *current;

	current = idx->current;

	//Gotoxy(idx->outputCol, idx->outputRow); cout << "----------------------\n"; idx->outputRow += 1;
	//Gotoxy(idx->outputCol, idx->outputRow); cout << "CURRENT BUNNY LIST\n"; idx->outputRow += 1;
	//Gotoxy(idx->outputCol, idx->outputRow); cout << "----------------------\n"; idx->outputRow += 1;
	//Gotoxy(idx->outputCol, idx->outputRow); cout << "  Name: " << current->name;
	//cout << "   Sex: " << conductor->sex;
	//cout << " Color: " << conductor->color;
	//cout << "   Age: " << conductor->age;
	//cout << "  RMVB: " << conductor->rmvb ? "** YES **" : "no";
	//cout << "Coords: " << current->row << "," << current->col; idx->outputRow += 1;

}

void killBunny(indexes *idx, bunny *killThisOne, bStats *stats, bool *p_stillHaveBunnies)
{
	void Gotoxy(int x, int y);
	int r, c;
	r = idx->current->row;
	c = idx->current->col;

	//Gotoxy(idx->outputCol, idx->outputRow);
	//cout << r << "," << c;
	//idx->outputRow += 1;

	stats->numDeaths += 1;
	// killing current;

	idx->board[r][c] = '.';
	//Gotoxy(idx->outputCol, idx->outputRow);
	//cout << " Kill: " << setw(3) << r << "," << setw(3) << c;

	//idx->outputRow += 1;
	Gotoxy(c, r);
	cout << ".";


	// when bunny to kill is the first one
	if (idx->first == killThisOne)
	{
		if (killThisOne->next == NULL)
		{
			//killing the FINAL bunny. All the bunnies are dead! Only ROOT exists now.
			
			idx->first = idx->root;
			idx->first->next = NULL;

			*p_stillHaveBunnies = false; // game over!

			return;
		}
		// Kiling the FIRST bunny in the list of bunnies.
		// copy next bunny to first bunny

		idx->first = idx->first->next;

		return;
	}

	struct bunny *prev = idx->root;

	// killing a bunny

	while (prev->next != NULL && prev->next != killThisOne)
		prev = prev->next;

	if (prev->next == NULL)
	{
		// can't find the bunny in the list
		return;
	}
	
	// skipping current bunny. previous bunny's NEXT set to bunny after the one being killed
	prev->next = prev->next->next; 

	return;
}

void checkForDeaths(indexes *idx, bStats *stats, bool *p_stillHaveBunnies)
{
	bunny *conductor;
	bunny *killThisOne;
	conductor = idx->first;
	void Gotoxy(int x, int y);
	bool actionTaken = false;

	while (conductor != NULL)
	{
		actionTaken = false;
		if (conductor->age >= MAX_AGE_ADULTS)
		{
			if (conductor->sex == 'X')
			{
				if (conductor->age < MAX_AGE_RMVB)
					return;
			}
			actionTaken = true;
			killThisOne = conductor;
			idx->current = killThisOne;
			killBunny(idx, killThisOne, stats, p_stillHaveBunnies);

			if (idx->first == idx->root)
				return;

		}

		conductor = conductor->next; // move to next bunny

	}
	if (!actionTaken)
	{
		Gotoxy(idx->outputCol, idx->outputRow);
		cout << "No deaths.";
		idx->outputRow += 1;
		// No action taken this round.
		return;
	}
	
}

void increaseAge(indexes *idx, bStats *stats)
{
	bunny *conductor;
	conductor = idx->first;
	void Gotoxy(int x, int y);

	Gotoxy(idx->outputCol, idx->outputRow);
	cout << "Advancing age of all bunnies.";
	idx->outputRow += 1;

	while (conductor != NULL)
	{
		// increase ages for all bunnies
		conductor->age += 1;
		if (conductor->age > 1)
		{
			if (conductor->sex == 'm' || conductor->sex == 'f')
			{
				if (conductor->sex == 'm')
				{
					conductor->sex = 'M';
					Gotoxy(conductor->col, conductor->row);
					cout << conductor->sex;

				}
				else
				{
					conductor->sex = 'F';
					Gotoxy(conductor->col, conductor->row);
					cout << conductor->sex;

				}
			}
		}
		conductor = conductor->next;
	}
	

}

void updateStats(indexes *idx, bStats *stats)
{
	bunny *conductor;

	conductor = idx->first;

	stats->numAdultMales = 0;
	stats->numAdultFemales = 0;
	stats->numJuvMales = 0;
	stats->numJuvFemales = 0;
	stats->numMales = 0;
	stats->numFemales = 0;
	stats->numRMVB = 0;
	stats->totalBunnies = 0;

	while (conductor != NULL)
	{
		stats->totalBunnies += 1;

		if (conductor->sex == 'M' || conductor->sex == 'm')
		{
			stats->numMales += 1;
			if (conductor->age > 1)
				stats->numAdultMales += 1;
			else
				stats->numJuvMales += 1;
		}

		if (conductor->sex == 'F' || conductor->sex == 'f')
		{
			stats->numFemales += 1;
			if (conductor->age > 1)
				stats->numAdultFemales += 1;
			else
				stats->numJuvFemales += 1;
		}

		if (conductor->rmvb)
			stats->numRMVB += 1;

		// move to next record
		conductor = conductor->next;
	}
	if (idx->root == idx->first)
		stats->totalBunnies = 0;  // since the only record is the root, there are no bunnies in the list


	//printBunnies(idx);
}

bool changeBunnyToRMVB(indexes *idx, int num)
{
	bunny *conductor;
	void Gotoxy(int x, int y);
	int len = 0;
	int i;

	conductor = idx->first;

	while (conductor != NULL)
	{
		conductor = conductor->next;
		len++;
	}

	if (len < num)
		return false;

	conductor = idx->first;

	for (i = 1; i < (len - num + 1); ++i)
		conductor = conductor->next;

	while (conductor->rmvb == true) // don't change an existing RMVB
	{
		return false;
	}

	conductor->rmvb = true;
	conductor->sex = 'X';
	Gotoxy(conductor->col, conductor->row);
	cout << conductor->sex;


	return true;

}


void checkForRMVB(indexes *idx, bStats  *stats)
{
	bunny *conductor;
	int i;
	int num;
	int numRMVB;
	int numRegularBunnies = 0;
	bool okToChange = true;
	void Gotoxy(int x, int y);

	numRMVB = stats->numRMVB;
	numRegularBunnies = stats->totalBunnies - stats->numRMVB;

	if (numRegularBunnies < numRMVB) // if the number of regular bunnies is now less than the number of RMVB, change remaining bunnies to RMVB
	{
		conductor = idx->first;
		if (stats->numMales == 0 && stats->numFemales == 0)
			return;

		while (conductor != NULL)
		{
			conductor->sex = 'X';
			Gotoxy(conductor->col, conductor->row);
			cout << "X";
			conductor = conductor->next;
		}
		updateStats(idx, stats);
		return;
	}

	if (numRMVB > 0)
	{
		for (i = 0; i < numRMVB; ++i)
		{
			num = getRandNum(1, stats->totalBunnies);
			okToChange = changeBunnyToRMVB(idx, num);

			if (! okToChange )
				i -= 1; // do not count this one since a change to RMVB was not made
			
		}
		updateStats(idx, stats);
	}


}

bool testBlankBoardSpace(indexes *idx, int r, int c)
{
	if (idx->board[r][c] == '.')
		return true;
	else
		return false;
}

bool testRealBunnyBoardSpace(indexes *idx, int r, int c)
{
	if (idx->board[r][c] == 'M'|| idx->board[r][c] == 'F' || idx->board[r][c] == 'm' || idx->board[r][c] == 'f')
		return true;
	else
		return false;
}

bool testRMVBBoardSpace(indexes *idx, int r, int c)
{
	if (idx->board[r][c] == 'X')
		return true;
	else
		return false;
}

void checkForBunniesNextToRMVB(indexes *idx, bStats  *stats)
{
	bunny *conductor;
	bunny *conductor2; // used to loop through all bunnies to match coords of real bunny to change to RMVB once coords are found
	int i;
	int num;
	int numRMVB;
	int tR, tC; // used to test direction from RMVB and see if there is a regular bunny there
	int numRegularBunnies = 0;
	int direction; // used for random number 0-3 for up, down, left, right to test to see if there is a regular bunny in those directions of RMVB
	bool foundBunnyToChange = false;
	bool okToChange = true;
	void Gotoxy(int x, int y);

	// bools below used to determine if there is a bunny around the RMVB to change
	bool triedUp = false, triedDown = false, triedLeft = false, triedRight = false;
	bool triedAllDirections = false;

	numRMVB = stats->numRMVB;

	if (numRMVB == 0)
		return;


	numRegularBunnies = stats->totalBunnies - stats->numRMVB;

	if (numRegularBunnies < numRMVB) // if the number of regular bunnies is now less than the number of RMVB, change remaining bunnies to RMVB
	{
		conductor = idx->first;
		if (stats->numMales == 0 && stats->numFemales == 0)
			return;

		while (conductor != NULL)
		{
			conductor->sex = 'X';
			Gotoxy(conductor->col, conductor->row);
			cout << "X";
			conductor = conductor->next;
		}
		updateStats(idx, stats);
		return;
	}

	conductor = idx->first; // reset conductor to loop through all bunnies, testing to see if there is a regular bunny next to an RMVB bunny. if so, change 1 of them to RMVB

	while (conductor != NULL)
	{
		if (conductor->sex == 'X')
			do
			{
				direction = getRandNum(0, 3);
				tR = conductor->row;
				tC = conductor->col;
				switch (direction)
				{
				case 0:
					triedUp = true;
					tR -= 1;
					break;
				case 1:
					triedDown = true;
					tR += 1;
					break;
				case 2:
					triedLeft = true;
					tC -= 1;
					break;
				case 3:
					triedRight = true;
					tC += 1;
					break;
				default:
					break;

				}

				if (testBlankBoardSpace(idx, tR, tC))
					foundBunnyToChange = false;
				else if (testRMVBBoardSpace(idx, tR, tC))
					foundBunnyToChange = false;
				else if (testRealBunnyBoardSpace(idx, tR, tC))
					foundBunnyToChange = true;

				

			} while (!foundBunnyToChange && !triedAllDirections);



			if (foundBunnyToChange)
			{
				idx->board[tR][tC] = 'X';
				conductor2 = idx->first;
				while (conductor2 != NULL)
				{
					if (conductor2->row == tR && conductor2->col == tC)
					{
						conductor2->sex = 'X';
						updateStats(idx, stats);
						break;
					}

					conductor2 = conductor2->next;
				}


			}

		conductor = conductor->next; // check next bunny
	}


	updateStats(idx, stats);


}







void Gotoxy(int x, int y)   //moves the cursor in the console window x = column, y = row
{
	COORD point;
	point.X = x+3;
	point.Y = y+1;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), point);
}

bool checkNewCoords(indexes *idx, int newRow, int newCol) 
{
	// check to see if new coords are outside the grid
	if (newRow < 0 || newRow >= MAX_BOARD_ROWS || newCol < 0 || newCol >= MAX_BOARD_COLUMS)
	{
		return false;
	}
	else
	{
		// check to see if new coords are occupied or not
		if (idx->board[newRow][newCol] != '.')
			return false;
		else
			return true;
	}


}

void moveAllBunnies(indexes *idx)
{
	bunny *conductor;
	int mR, mC;    // moveRow and moveCol
	int direction; // move up, down, left, right based on random # 0, 1, 2, 3
	bool getNewDirection = true;
	bool triedUp = false, triedDown = false, triedLeft = false, triedRight = false;
	bool triedAllDirections = false;
	bool canMove = true;
	
	conductor = idx->first;

	

	while (conductor != NULL)
	{
		
		do
		{
			mR = conductor->row;
			mC = conductor->col;
			
			direction = getRandNum(0, 3);      // get direction to move

			// get new coords based on direction
			switch (direction)
			{
			case 0:
				triedUp = true;
				mR = conductor->row - 1;
				break;
			case 1:
				triedDown = true;
				mR = conductor->row + 1;
				break;
			case 2:
				triedLeft = true;
				mC = conductor->col - 1;
				break;
			case 3:
				triedRight = true;
				mC = conductor->col + 1;
				break;
			default:
				break;
			}

			if (triedUp && triedDown && triedLeft && triedRight)
			{
				//Gotoxy(idx->outputCol, idx->outputRow);
				//cout << "Tried moving all directions...";
				//idx->outputRow += 1;
				triedAllDirections = true;
				canMove = false;
				break;
			}

			//Gotoxy(idx->outputCol, idx->outputRow);
			//cout << "Trying these coords: " << mR << "," << mC;
			//idx->outputRow += 1;


		} while (!checkNewCoords(idx, mR, mC) && !triedAllDirections);
		

		Gotoxy(conductor->col, conductor->row);  // move to current coord
		cout << ".";                             // replace current coord with .
		Gotoxy(mC, mR);                          // move to new coord (up, down, left, right) of current position
		cout << conductor->sex;                  // place sex in new spot
		conductor->row = mR;                     // update row coord of bunny
		conductor->col = mC;                     // update col coord of bunny

		
		
		conductor = conductor->next;
	}


}

void checkForBirths(indexes *idx, bStats *stats)
{
	void Gotoxy(int x, int y);
	bunny *conductor;
	conductor = idx->first;
	//int mColor;

	if (stats->numAdultMales > 0 && stats->numAdultFemales > 0) // have to have at least 1 adult male and 1 adult female to have babies

	{
		while (conductor != NULL)
		{
			if (conductor->sex == 'F' && conductor->age > 2)
			{
				// giving birth
				idx->mom = conductor; // saves mom to pass to giveBirth and check coordinates, etc.
				//mColor = conductor->colorNum;  // saves the color of Mom - now that I have idx->mom I may could get rid of this mColor var
				//Gotoxy(idx->outputCol, idx->outputRow);
				//cout << "Mom's coords: " << idx->mom->row << "," << idx->mom->col;
				//idx->outputRow += 1;
				giveBirth(idx, stats, idx->mom->colorNum);
				updateStats(idx, stats);
			}
			conductor = conductor->next;
		}
	}

}



void takeTurn(indexes *idx, bStats *stats, bool *p_stillHaveBunnies)
{
	bunny *conductor;
	void displayMenu(indexes *idx, bStats *stats);
	void drawIdxBoard(indexes *idx);
	void clearSideOutput(indexes *idx);

	//int mColor;

	do
	{


		clearSideOutput(idx);
		moveAllBunnies(idx);
		increaseAge(idx, stats);
		updateStats(idx, stats);

		//Gotoxy(idx->outputCol, idx->outputRow);
		//cout << "Bunnies after increase age:";
		//idx->outputRow += 1;
		//printBunnies(idx);

		checkForDeaths(idx, stats, p_stillHaveBunnies);
		updateStats(idx, stats);
		
		//Gotoxy(idx->outputCol, idx->outputRow);
		//cout << "Bunnies after check for deaths:";
		//idx->outputRow += 1;
		//printBunnies(idx);

		checkForBirths(idx, stats); // created this function based on commented section below

		//Gotoxy(idx->outputCol, idx->outputRow);
		//cout << "Bunnies after check for births:";
		//idx->outputRow += 1;
		//printBunnies(idx);

		//conductor = idx->first;

		//if (stats->numAdultMales > 0 && stats->numAdultFemales > 0) // have to have at least 1 adult male and 1 adult female to have babies

		//{
		//	while (conductor != NULL)
		//	{
		//		if (conductor->sex == 'F' && conductor->age > 2)
		//		{
		//			// giving birth
		//			mColor = conductor->colorNum;  // saves the color of Mom
		//			giveBirth(idx, stats, mColor);
		//			updateStats(idx, stats);
		//		}
		//		conductor = conductor->next;
		//	}
		//}

		// checkForRMVB(idx, stats);
		checkForBunniesNextToRMVB(idx, stats);

		//Gotoxy(idx->outputCol, idx->outputRow);
		//cout << "Bunnies after check for RMVB:";
		//idx->outputRow += 1;
		//printBunnies(idx);


		// end of turn
		stats->numTurns += 1;
		updateStats(idx, stats);
		updateLastBunny(idx);

		printStatsColumn(idx, stats);

		Gotoxy(-3, -1);  // moves cursor to top, left so the console windows is always at the top
		//clearSideOutput(idx);

		//Gotoxy(idx->outputCol, idx->outputRow);
		//cout << "Bunnies after move all bunnies:";
		//idx->outputRow += 1;
		//printBunnies(idx);

	
	} while (stats->numMales == 0 && stats->numFemales == 0 && stats->numRMVB != 0); // automate the loop when no females are left becuase there will be no more births

	//Gotoxy(idx->outputCol, idx->outputRow);
	//cout << "Bunnies at end of turn:";
	//idx->outputRow += 1;
	//printBunnies(idx);

	displayMenu(idx, stats);
	//getchar(); // press any key to being next turn

	clearSideOutput(idx);  // clears the existing output information on right side of board, ready for next turn's info

}
void clearSideOutput(indexes *idx)
{
	int r, c;
	c = idx->outputCol;

	for (r = 0; r <= idx->outputRow; ++r)
	{
		Gotoxy(c, r);
		cout << "                                                ";

	}

	idx->outputRow = 0;
	return;
}

void drawIdxBoard(indexes *idx)
{
	int r, c, i;

	system("cls"); // clear the screen and re-draw

	for (i = 0; i < MAX_BOARD_COLUMS; ++i)
	{
		if (i == 0)
			cout << "   0";

		else
			if (i % 10 == 0)
				cout << i / 10;

			else
				cout << " ";

	}
	cout << "\n";


	for (r = 0; r < MAX_BOARD_ROWS; ++r)
	{
		cout << setw(2) << r << " ";

		for (c = 0; c < MAX_BOARD_COLUMS; ++c)
		{
			cout << idx->board[r][c];

		}
		cout << setw(3) << r << "\n";

	}

	for (i = 0; i < MAX_BOARD_COLUMS; ++i)
	{
		if (i == 0)
			cout << "   0";

		else
			if (i % 10 == 0)
				cout << i / 10;

			else
				cout << " ";

	}
	cout << "\n";

}

void displayMenu(indexes *idx, bStats *stats)
{
	void Gotoxy(int x, int y);

	Gotoxy(0, 0);

	int r, c;
	r = idx->outputRow;
	c = idx->outputCol;
	
	Gotoxy(c, r); cout << "--------------------- "; r++;
	Gotoxy(c, r); cout << "     MAIN MENU        "; r++;
	Gotoxy(c, r); cout << "--------------------- "; r++;
	Gotoxy(c, r); cout << "(L)ist of bunnies     "; r++;
	Gotoxy(c, r); cout << "(S)tatistics          "; r++;
	Gotoxy(c, r); cout << "(N)ext turn           "; r++;
	Gotoxy(c, r); cout << "(E)nd game            "; r++;

	Gotoxy(c, r); cout << "                      "; r++;
	Gotoxy(c, r); cout << "Enter your selection: "; r++;

	cin.get(); // gets any key to continue. does not save input

	idx->outputRow = r; // saves row ready for next input
}


int main()
{
	srand((unsigned)time(NULL)); // generate random seed each time the program runs

	int i;

	bunny *conductor;
	indexes *idx;
	bStats *stats;

	void initializeIdxBoard(indexes *idx);
	void killBunny(indexes *idx, bunny *conductor, bStats *stats, bool *p_stillHaveBunnies);
	void checkForDeaths(indexes *idx, bStats *stats, bool *p_stillHaveBunnies);
	void printBunnies(indexes *idx);
	void printCurrentBunny(indexes *idx);
	bool isRMVB();
	char getRandomSex();
	void createRoot(indexes *idx);
	void updateLastBunny(indexes *idx);
	void initializeFirstBunnies(indexes *idx, bStats *stats);
	void initializeStats(bStats *stats);
	void printStats(bStats *stats);
	void takeTurn(indexes *idx, bStats *stats, bool *p_stillHaveBunnies);
	void giveBirth(indexes *idx, bStats *stats, int colorOfMom);
	void increaseAge(indexes *idx, bStats *stats);
	void updateStats(indexes *idx, bStats *stats);
	void checkForRMVB(indexes *idx, bStats  *stats);
	bool changeBunnyToRMVB(indexes *idx, int num);
	void checkForBunniesNextToRMVB(indexes *idx, bStats  *stats);
	void placeBunnyOnBoard(indexes *idx, char marker);
	void placeRandomBunnyOnBoard(indexes *idx, char marker);
	void printStatsColumn(indexes *idx, bStats *stats);
	void clearSideOutput(indexes *idx);
	void Gotoxy(int x, int y);
	bool haveBunnies = true;
	bool *p_stillHaveBunnies = &haveBunnies;
	void moveAllBunnies(indexes *idx);
	void checkForBirths(indexes *idx, bStats *stats);
	bool testBlankBoardSpace(indexes *idx, int r, int c);
	bool testRealBunnyBoardSpace(indexes *idx, int r, int c);
	bool testRMVBBoardSpace(indexes *idx, int r, int c);

	stats = new bStats;
	
	idx = new indexes;
	idx->outputCol = 90;
	idx->outputRow = 0;
	
	initializeIdxBoard(idx);
	initializeStats(stats);
	drawIdxBoard(idx);
	Gotoxy(0, 0);
	cout << "*";
	idx->outputCol = OUTPUT_COL;

	// INITIALIZE THE ROOT RECORD
	// create ROOT record at head of the list. This record will not change and be named ROOT. this will NOT be a bunny
	createRoot(idx);

	idx->first = idx->root; // first bunny record should start here. 
	idx->last = idx->root;  // last record is here, too
	idx->root->next = NULL; // next record with NULL means it is the last record in the list

	// END INITIALIZATION

	initializeFirstBunnies(idx, stats);
	conductor = idx->first;
	printBunnies(idx);
	cin.get();

	i = 0;

	while (haveBunnies)
	{
		i++;
		takeTurn(idx, stats, p_stillHaveBunnies);
	}

	//Gotoxy(0, 95);
	//cout << "FINAL STATISTICS AT END OF GAME. THANK YOU FOR PLAYING.\n";

	//printStats(stats);

	// end of program
	Gotoxy(idx->outputCol, idx->outputRow + 2);
	cout << "GAME OVER. Press any key to exit.";
	cin.get();



    return 0;
}

