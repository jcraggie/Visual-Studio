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
	struct bunny   *current; // used to pass the address of the current bunny being worked with
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

	if (sex_num < 0 || sex_num > 1)
	{
		printf("invalid sex!\n");
		printf("pausing for error...\n");
		getchar();
	}

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

	bunny *current;

	r = getRandNum(0, MAX_BOARD_ROWS-1);
	c = getRandNum(0, MAX_BOARD_COLUMS-1);

	while (idx->board[r][c] != '.')
	{
		r = getRandNum(0, MAX_BOARD_ROWS-1);
		c = getRandNum(0, MAX_BOARD_COLUMS-1);
	}
	
	// save coords assinged to bunny's info
	idx->current->row = r;
	idx->current->col = c;

	// place the marker on the board. marker is the sex of the bunny for now
	idx->board[r][c] = marker;
	Gotoxy(idx->outputCol, idx->outputRow);
	printf("Place: %3i,%3i", r, c);
	idx->outputRow += 1;
	Gotoxy(c, r);
	printf("%c", marker);
	//getchar();
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


		placeBunnyOnBoard(idx, conductor->sex);  // replaces above code to put the bunny on the board

		// update counts below
		updateStats(idx, stats);

	}
	idx->last = conductor;
	
}



void giveBirth(indexes *idx, bStats *stats, int colorOfMom)
{
	void printBunnies(indexes *idx);

	stats->numBirths += 1;
	//int i;
	int num; // used for random numbers when assigning values to bunny
	bunny *conductor; // use this to naviate through the list
	//bunny *current;
	bool isJuv = false;
	bool isAdult = false;
	bool isMale = false;
	bool isFemale = false;
	bool isaRMVB = false;
	//initialize color counters in the future here
	
	// get to end of the list
	conductor = idx->root;
	while (conductor->next != NULL)
		conductor = conductor->next;
	idx->last = conductor;

	conductor = idx->last;
	// create new bunny
	conductor->next = new bunny;
	conductor = conductor->next;
	conductor->next = NULL;
	idx->last = conductor; // update last bunny to new one just made


	conductor->sex = getRandomSex();
	//printf("getting sex result is %c\n", conductor->sex);
	if (conductor->sex == 'M')
	{
		isMale = true;
		conductor->sex = 'm';
	}
	if (conductor->sex == 'F')
	{
		isFemale = true;
		conductor->sex = 'f';
	}
	if (conductor->sex != 'm' && conductor->sex != 'f' && conductor->sex != 'X')
	{
		printf("sex error... pausing.\n");
		getchar();
	}

	conductor->rmvb = isRMVB();
	if (conductor->rmvb)
	{
		isaRMVB = true;
		conductor->sex = 'X';
		isMale = false;
		isFemale = false;
	}
	conductor->age = 0;

	num = getRandNum(0, MAX_NAMES - 1);
	strcpy_s(conductor->name, bunnyNames[num].bName);

	conductor->colorNum = colorOfMom;
	strcpy_s(conductor->color, bunnyColors[colorOfMom].bColor);
	
	idx->current = conductor;
	placeBunnyOnBoard(idx, conductor->sex);

}

void printStatsColumn(indexes *idx, bStats *stats)
{
	void Gotoxy(int x, int y);


	int r, c;
	r = idx->outputRow;
	c = idx->outputCol;

	Gotoxy(c, r);printf("---------------------     ");r++;
	Gotoxy(c, r);printf("  BUNNY STATISTICS        ");r++;
	Gotoxy(c, r);printf("---------------------     ");r++;
	Gotoxy(c, r);printf("      Total Males: %i", stats->numMales);r++;
	Gotoxy(c, r);printf("    Total Females: %i", stats->numFemales);r++;
	Gotoxy(c, r);printf("             RMVB: %i", stats->numRMVB);r++;
	Gotoxy(c, r);printf("    Total Bunnies: %i", stats->totalBunnies);r++;
	Gotoxy(c, r);printf("                           ");r++;
	Gotoxy(c, r);printf("      Adult Males: %i",stats->numAdultMales);r++;
	Gotoxy(c, r);printf("    Adult Females: %i", stats->numAdultFemales);r++;
	Gotoxy(c, r);printf("                           ");r++;
	Gotoxy(c, r);printf("   Juvenlie Males: %i", stats->numJuvMales);r++;
	Gotoxy(c, r);printf(" Juvenile Females: %i", stats->numJuvFemales);r++;
	Gotoxy(c, r);printf("                           ");r++;
	Gotoxy(c, r);printf("           Births: %i", stats->numBirths);r++;
	Gotoxy(c, r);printf("           Deaths: %i", stats->numDeaths);r++;
	Gotoxy(c, r);printf("                           ");r++;
	Gotoxy(c, r);printf("Total turns taken: %i", stats->numTurns);r++;
	Gotoxy(c, r);printf("---------------------       ");r++;
	Gotoxy(c, r);printf("                            ");r++;

	idx->outputRow = r;
}



void printStats(bStats *stats)
{
	printf("-----------------------------------------------------------------------------------------\n");
	printf("  BUNNY STATISTICS AS OF TURN %i                                Total Bunnies: %i\n", stats->numTurns, stats->totalBunnies);
	printf("-----------------------------------------------------------------------------------------\n");
	printf("   Juvenlie Males: %i    Juvenile Females: %i             RMVB: %i\n", stats->numJuvMales, stats->numJuvFemales, stats->numRMVB);
	printf("      Adult Males: %i       Adult Females: %i\n", stats->numAdultMales, stats->numAdultFemales);
	printf("      Total Males: %i       Total Females: %i\n", stats->numMales, stats->numFemales);
	printf("\n");
	printf("           Births: %i\n", stats->numBirths);
	printf("           Deaths: %i\n", stats->numDeaths);
	printf("-----------------------------------------------------------------------------------------\n");
	printf("\n");
}



void printBunnies(indexes *idx)
{
	bunny *conductor;
	
	conductor = idx->first;

	printf("----------------------\n");
	printf("CURRENT BUNNY LIST\n");
	printf("----------------------\n");
	while (conductor != NULL)
	{
		printf("  Name: %s", conductor->name);
		printf("   Sex: %c", conductor->sex);
		printf(" Color: %s", conductor->color);
		printf("   Age: %i", conductor->age);
		printf("  RMVB: %s", conductor->rmvb ? "** YES **" : "no");
		printf(" Coords: %i,%i\n", conductor->row, conductor->col);
		//printf("----------------------\n");
		conductor = conductor->next;
	}
}

void killBunny(indexes *idx, bunny *killThisOne, bStats *stats, bool *p_stillHaveBunnies)
{
	void Gotoxy(int x, int y);
	int r, c;
	r = idx->current->row;
	c = idx->current->col;
	stats->numDeaths += 1;
	//printf("current is being killed. current's name is %s\n", idx->current->name);
	idx->board[r][c] = '.';
	Gotoxy(idx->outputCol, idx->outputRow);
	printf(" Kill: %3i,%3i", r, c);
	idx->outputRow += 1;
	Gotoxy(c, r);
	printf("%c", '.');
	//getchar();

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
		// No action taken this round.
		return;
	}
	
}

void increaseAge(indexes *idx, bStats *stats)
{
	bunny *conductor;
	conductor = idx->first;
	void Gotoxy(int x, int y);

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
					printf("%c",conductor->sex);
				}
				else
				{
					conductor->sex = 'F';
					Gotoxy(conductor->col, conductor->row);
					printf("%c", conductor->sex);
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
	printf("%c", conductor->sex);

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

	numRMVB = stats->numRMVB;
	numRegularBunnies = stats->totalBunnies - stats->numRMVB;

	if (numRegularBunnies < numRMVB)
	{
		conductor = idx->first;

		while (conductor != NULL)
		{
			conductor->sex = 'X';
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


void Gotoxy(int x, int y)   //moves the cursor in the console window
{
	COORD point;
	point.X = x+3;
	point.Y = y+1;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), point);
}

void takeTurn(indexes *idx, bStats *stats, bool *p_stillHaveBunnies)
{
	bunny *conductor;

	void drawIdxBoard(indexes *idx);
	void clearSideOutput(indexes *idx);

	int mColor;


	increaseAge(idx, stats);
	updateStats(idx, stats);

	checkForDeaths(idx, stats, p_stillHaveBunnies);
	updateStats(idx, stats);

	conductor = idx->first;

	if (stats->numAdultMales > 0 && stats->numAdultFemales > 0) // have to have at least 1 adult male and 1 adult female to have babies

	{
		while (conductor != NULL)
		{
			if (conductor->sex == 'F' && conductor->age > 2)
			{
				// giving birth
				mColor = conductor->colorNum;  // saves the color of Mom
				giveBirth(idx, stats, mColor);
				updateStats(idx, stats);
			}
			conductor = conductor->next;
		}
	}

	checkForRMVB(idx, stats);

	// end of turn
	stats->numTurns += 1;
	updateStats(idx, stats);
	updateLastBunny(idx);

	printStatsColumn(idx, stats);

	Gotoxy(-3,-1);  // moves cursor to top, left so the console windows is always at the top
	getchar(); // press any key to being next turn

	clearSideOutput(idx);  // clears the existing output information on right side of board, ready for next turn's info

}
void clearSideOutput(indexes *idx)
{
	int r, c;
	c = idx->outputCol;
	Gotoxy(90, 50);
	printf("output rows are: %i", idx->outputRow);
	//r = 0;

	for (r = 0; r <= idx->outputRow; ++r)
	{
		Gotoxy(c, r);
		printf("                                 ");
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
			printf("   0");
		else
			if (i % 10 == 0)
				printf("%i", i / 10);
			else
				printf(" ");
	}
	printf("\n");

	for (r = 0; r < MAX_BOARD_ROWS; ++r)
	{
		printf("%2i ", r);
		for (c = 0; c < MAX_BOARD_COLUMS; ++c)
		{
			printf("%c", idx->board[r][c]);
		}
		printf(" %i\n", r);
	}

	for (i = 0; i < MAX_BOARD_COLUMS; ++i)
	{
		if (i == 0)
			printf("   0");
		else
			if (i % 10 == 0)
				printf("%i", i / 10);
			else
				printf(" ");
	}
	printf("\n");
}



void drawBoard(char b[MAX_BOARD_ROWS][MAX_BOARD_COLUMS])
{
	int r, c;

	system("cls"); // clear the screen and re-draw

	for (r = 0; r < MAX_BOARD_ROWS; ++r)
	{
		for (c = 0; c < MAX_BOARD_COLUMS; ++c)
			printf("%c", b[r][c]);
		printf("\n");
	}
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
	void placeBunnyOnBoard(indexes *idx, char marker);
	void printStatsColumn(indexes *idx, bStats *stats);
	void clearSideOutput(indexes *idx);
	void Gotoxy(int x, int y);
	bool haveBunnies = true;
	bool *p_stillHaveBunnies = &haveBunnies;

	stats = new bStats;
	
	idx = new indexes;
	idx->outputCol = 90;
	idx->outputRow = 0;
	
	initializeIdxBoard(idx);
	initializeStats(stats);
	drawIdxBoard(idx);
	Gotoxy(0, 0);
	printf("*");
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

	i = 0;

	while (haveBunnies)
	{
		i++;
		takeTurn(idx, stats, p_stillHaveBunnies);
	}

	Gotoxy(0, 95);
	printf("FINAL STATISTICS AT END OF GAME. THANK YOU FOR PLAYING.\n");
	printStats(stats);

	// end of program
	printf("Press any key to exit...");
	getchar();
	getchar();


    return 0;
}

