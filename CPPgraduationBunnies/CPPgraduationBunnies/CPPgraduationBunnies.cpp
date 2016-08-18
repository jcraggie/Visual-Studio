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


// DEFINE CONSTANTS
#define MAX_NAMES         10
#define MAX_COLORS         4
#define MAX_START_BUNNIES  5
#define MAX_BOARD_ROWS    80
#define MAX_BOARD_COLUMS  80

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
	char           color[15];   // white, brown, black, spotted
	bool           rmvb;        // radioactive_mutant_vampire_bunny true / false
	int            row;         // row coord of bunny on 80 x 80 grid
	int            col;         // col coord of bunny on 80 x 80 grid
	struct bunny   *next;       // points to next bunny in the list




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
};

void initializeStats(bStats *stats)
{
	//bStats *stat;
	//stat = stats;

	stats->numAdultMales = 0;
	stats->numAdultFemales = 0;
	stats->numJuvMales = 0;
	stats->numJuvFemales = 0;
	stats->numMales = 0;
	stats->numFemales = 0;
	stats->numBirths = 0;
	stats->numDeaths = 0;
	stats->numRMVB = 0;
	stats->totalBunnies = 0;
}

struct bNames
{
	char bName[15];
};

struct bColors
{
	char bColor[15];
};

const struct bNames bunnyNames[10] =
{
	{"Thumper"},
	{"Cottontail"},
	{"Peter"},
	{"Beatrix"},
	{"Brer Rabbit"},
	{"Trix"},
	{"Jack"},
	{"Jenny"},
	{"Barbara"},
	{"Jessica"}
};

const struct bColors bunnyColors[4] =
{
	{"white"},
	{"brown"},
	{"black"},
	{"spotted"}
};

void createRoot(bunny *root)
{
	//root = new bunny; // create ROOT record at head of the list. This record will not change and be named ROOT
	root->next = NULL; // NULL incdiates this is the end of the list
	strcpy_s(root->name,"ROOT");
	root->age = 0;
	root->sex = 'F';
	root->row = 0;
	root->col = 0;
	strcpy_s(root->color, bunnyColors[2].bColor);
	root->rmvb = 0;

}

//void updateLastBunny(bunny *root, bunny *last)
//{
//	bunny *conductor;
//	conductor = root;
//
//	if (conductor != 0)
//	{
//		while (conductor->next != 0)
//			conductor = conductor->next;
//	}
//	last = conductor;
//
//}

char getRandomSex()
{
	int min, max;
	int sex_num;

	min = 0; // (F)emale
	max = 1; // (M)ale

	sex_num = getRandNum(min, max);

	if (sex_num == 0)
		return 'F';
	else
		return 'M';

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
	return (rand() % 100) < 2;
}

void addNewBunny(bunny *last)
{
	last->next = new bunny;
	last = last->next;
	last->next = 0;
	strcpy_s(last->name, "NEW LAST");
}

void initializeFirstBunnies(bunny *root, bunny *first, bunny *last, bStats *stats)
{
	int i;
	int num; // used for random numbers when assigning values to bunny
	bunny *conductor; // use this to naviate through the list
	bool isJuv = false;
	bool isAdult = false;
	bool isMale = false;
	bool isFemale = false;
	bool isaRMVB = false;
	//initialize color counters in the future here

	conductor = first;

	last = first; // now last point to the first bunny since it is the only bunny


	for (i = 0; i < MAX_START_BUNNIES; ++i)
	{
		isJuv = false;
		isAdult = false;
		isMale = false;
		isFemale = false;
		isaRMVB = false;

		conductor->next = new bunny;
		conductor = conductor->next;
		conductor->next = 0;	

		conductor->rmvb = isRMVB();
		if (conductor->rmvb)
			isaRMVB = true;


		conductor->sex = getRandomSex();
		if (conductor->sex == 'M')
			isMale = true;
		else
			isFemale = true;

		conductor->age = getRandNum(0, 9);  // random age between 0 and 9 (10 is dead) (50 is max for rmvb's)
		if (conductor->age < 2)
			isJuv = true;
		else
			isAdult = true;

		num = getRandNum(0,MAX_NAMES-1);
		strcpy_s(conductor->name, bunnyNames[num].bName);

		num = getRandNum(0, MAX_COLORS - 1);
		strcpy_s(conductor->color, bunnyColors[num].bColor);
		// bool for color counters go here in the future

		// update counts below
		stats->totalBunnies += 1;
		if (isMale)
		{
			stats->numMales += 1;
			if (isJuv)
				stats->numJuvMales += 1;
			else
				stats->numAdultMales += 1;

		}
		if (isFemale)
		{
			stats->numFemales += 1;
			if (isJuv)
				stats->numJuvFemales += 1;
			else
				stats->numAdultFemales += 1;

		}
		if (isaRMVB)
			stats->numRMVB += 1;
		
	}
	// trying to adjust last, but it does not update outside of this function
	// investigate later

	//last = root;
	//while (last->next != NULL)
	//	last = last->next;
	
}

void printStats(bStats *stats)
{
	//bStats *stat;
	//stat = stats;

	printf("  BUNNY STATISTICS\n");
	printf("--------------------\n");
	printf("     Adult Males: %i\n",stats->numAdultMales);
	printf("   Adult Females: %i\n", stats->numAdultFemales);
	printf("\n");
	printf("  Juvenlie Males: %i\n", stats->numJuvMales);
	printf("Juvenile Females: %i\n", stats->numJuvFemales);
	printf("\n");
	printf("     Total Males: %i\n", stats->numMales);
	printf("   Total Females: %i\n", stats->numFemales);
	printf("\n");
	printf("          Births: %i\n", stats->numBirths);
	printf("          Deaths: %i\n", stats->numDeaths);
	printf("\n");
	printf("            RMVB: %i\n", stats->numRMVB);
	printf("\n");
	printf("   Total Bunnies: %i\n", stats->totalBunnies);
	printf("--------------------\n");
	printf("\n");
}



void printBunnies(bunny *first, bool *p_stillHaveBunnies)
{
	bunny *conductor;
	
	conductor = first;
	printf("Still Have Bunnies: %d\n", *p_stillHaveBunnies);
	printf("----------------------\n");
	while (conductor != NULL)
	{
		printf("  Name: %s\n", conductor->name);
		printf("   Sex: %c\n", conductor->sex);
		printf(" Color: %s\n", conductor->color);
		printf("   Age: %i\n", conductor->age);
		printf("  RMVB: %d\n", conductor->rmvb);
		printf("----------------------\n");
		conductor = conductor->next;
	}
}

void killBunny(bunny *root, bunny *first, bunny *killThisOne, bStats *stats, bool *p_stillHaveBunnies)
{
	// when bunny to kill is the first one
	if (first == killThisOne)
	{
		if (killThisOne->next == NULL)
		{
			printf("Killing bunny %s, who is the FINAL KILL.\n", killThisOne->name);
			printf("All the bunnies are dead! Only ROOT exists now. These should be the final stats.\n");


			first = root;
			first->next = NULL;

			printStats(stats);
			printBunnies(root, p_stillHaveBunnies);
			printf("Setting p_stillHaveBunnies to FALSE.\n");
			*p_stillHaveBunnies = false;

			return;
		}
		printf("Killing bunny %s, who is FIRST in the list of bunnies. After the kill, stats are below.\n", killThisOne->name);


		// copy next bunny to first bunny
		strcpy_s(first->name, first->next->name);
		first->age = first->next->age;
		first->sex = first->next->sex;
		strcpy_s(first->color, first->next->color);
		first->rmvb = first->next->rmvb;
		first->row = first->next->row;
		first->col = first->next->col;
		killThisOne = first->next;
		first->next = first->next->next;
		//free(killThisOne);

		printStats(stats);
		printBunnies(root, p_stillHaveBunnies);

		return;
	}



	struct bunny *prev = root;

	printf("Killing bunny %s. After the kill, stats are below.\n", killThisOne->name);
	

	while (prev->next != NULL && prev->next != killThisOne)
		prev = prev->next;

	if (prev->next == NULL)
	{
		// printf("Can't find the bunny to be killed in the list.\n");
		return;
	}
	prev->next = prev->next->next;

	printStats(stats);
	printBunnies(root, p_stillHaveBunnies);

	//free(killThisOne);

	return;
}

void checkForDeaths(bunny *root, bunny *first, bStats *stats, bool *p_stillHaveBunnies)
{
	bunny *conductor;
	bunny *killThisOne;
	conductor = first;
	bool actionTaken = false;

	while (conductor != NULL)
	{
		actionTaken = false;
		if (conductor->age >= 10)
		{
			actionTaken = true;

			printf("Age is: %i  Sex is: %c. Updating stats. \n", conductor->age, conductor->sex);
			// update stats before killing the bunny
			stats->totalBunnies -= 1;
			if (conductor->sex == 'M')
			{
				printf("Deducting Adult Male.\n");
				stats->numAdultMales -= 1;
				stats->numMales -= 1;
			}
			else
			{
				printf("Deducting Adult Female.\n");
				stats->numAdultFemales -= 1;
				stats->numFemales -= 1;
			}
			if (conductor->rmvb)
			{
				printf("Deducting RMVB.\n");
				stats->numRMVB -= 1;
			}
			// adjust colors stats in the future here

			killThisOne = conductor;

			killBunny(root, first, killThisOne, stats, p_stillHaveBunnies);

			if (first == root)
				return;

		}

		conductor = conductor->next; // move to next bunny

	}
	if (!actionTaken)
	{
		printf("No action taken. Here are the current stats.\n");
		printStats(stats);
		printBunnies(root, p_stillHaveBunnies);
	}
	
}

void takeTurn(bunny *root, bunny *first, bStats *stats, bool *p_stillHaveBunnies)
{
	bunny *conductor;
	conductor = first;

	while (conductor != NULL)
	{
		conductor->age += 1;
		if (conductor->age == 2)
		{
			if (conductor->sex == 'M')
			{
				stats->numJuvMales -= 1;
				stats->numAdultMales += 1;
			}
			else
			{
				stats->numJuvFemales -= 1;
				stats->numAdultFemales += 1;
			}

		}

		// future code to move bunny randonly 1 space up, down, left, right

		// done and ready to move to next bunny
		conductor = conductor->next;
	}
	checkForDeaths(root, first, stats, p_stillHaveBunnies);
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

	bunny *root;	// this is the start of the list. this record will never change and will have the name "ROOT"
	bunny *first;
	bunny *last;
	bunny *conductor;

	bStats *stats;

	char board[MAX_BOARD_ROWS][MAX_BOARD_COLUMS]; // creates bunny board

	void killBunny(bunny *root, bunny *first, bunny *conductor, bStats *stats, bool *p_stillHaveBunnies);
	void checkForDeaths(bunny *first, bStats *stats, bool *p_stillHaveBunnies);
	void printBunnies(bunny *first, bool *p_stillHaveBunnies);
	bool isRMVB();
	char getRandomSex();
	void createRoot(bunny *root);
	//void updateLastBunny(bunny *root, bunny *last);
	void addNewBunny(bunny *last);
	void initializeFirstBunnies(bunny *root, bunny *first, bunny *last, bStats *stats);
	void initializeStats(bStats *stats);
	void printStats(bStats *stats);
	void takeTurn(bunny *root, bunny *first, bStats *stats, bool *p_stillHaveBunnies);

	stats = new bStats;

	bool haveBunnies = true;

	bool *p_stillHaveBunnies = &haveBunnies;





	initializeBoard(board);
	initializeStats(stats);

	// INITIALIZE THE ROOT RECORD

	root = new bunny;    // create ROOT record at head of the list. This record will not change and be named ROOT. this will NOT be a bunny
	createRoot(root);

	first = root; // first bunny record should start here. 
	last = root;
	root->next = NULL; // 0 incdiates this is the end of the list

	strcpy_s(root->name, "ROOT");

	// END INITIALIZATION



	//updateLastBunny(root, last);
	// addNewBunny(last);



	// ALL TESTING DONE BELOW HERE



	initializeFirstBunnies(root, first, last, stats);
	first = root->next; // sets the first bunny to the record after ROOT

	// iterate through bunny after creating new last - used for debugging purposes only
	conductor = first;
	printf("5 BUNNY NAMES IN OUR INITIALIZED LIST\n");
	printBunnies(root, p_stillHaveBunnies);

	last = root;
	while (last->next != NULL)
		last = last->next;
	printf("\n");
	printf("The last bunny is: %s\n\n", last->name);

	printf("\n");

	printStats(stats);

	printf("Taking turns:\n");
	//for (i = 0; i < 10; ++i)
	//{
	//	printf("Turn %i: ", i);
	//	takeTurn(root, first, stats);
	//}

	i = 0;
	while (haveBunnies)
	{
		i++;
		printf("Turn %i:   haveBunnies: %d\n", i, haveBunnies);
		takeTurn(root, first, stats, p_stillHaveBunnies);
	}
	printf("\n");

	printf("\n");

	printStats(stats);
	printBunnies(root, p_stillHaveBunnies);



	//// testing printing bunny names - used for debugging only
	//printf("NAME DICTIONARY LIST\n");
	//for (i = 0; i < MAX_NAMES; ++i)
	//	printf("%s\n", bunnyNames[i].bName);
	//printf("\n");

	//// testing printing colors - used for debugging only
	//printf("COLOR LIST\n");
	//for (i = 0; i < MAX_COLORS; ++i)
	//	printf("%s\n", bunnyColors[i].bColor);
	//printf("\n");

	// drawBoard(board);

	// end of program
	printf("Press any key to exit...");
	getchar();


    return 0;
}

