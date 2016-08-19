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

const struct bNames bunnyNames[10] =
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
	return (rand() % 100) < 2;
}

void addNewBunny(bunny *last)
{
	last->next = new bunny;
	last = last->next;
	last->next = 0;
	strcpy_s(last->name, "NEW LAST");
}

void initializeFirstBunnies(indexes *idx, bStats *stats)
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
		if (i == 0)
		{
			idx->first = conductor;
			idx->last = conductor;
		}

		if (i == MAX_START_BUNNIES - 1)
		{
			idx->last = conductor;
		}

		conductor->sex = getRandomSex();
		if (conductor->sex == 'M')
			isMale = true;
		if (conductor->sex == 'F')
			isFemale = true;
		if (conductor->sex != 'M' && conductor->sex != 'F' && conductor->sex != 'X')
		{
			printf("sex error... pausing.\n");
			getchar();
		}

		conductor->rmvb = isRMVB(); // return 1 if yes, 0 if no
		if (conductor->rmvb)
		{
			isaRMVB = true;
			isMale = false;
			isFemale = false;
			conductor->sex = 'X';
		}


		conductor->age = getRandNum(0, 9);  // random age between 0 and 9 (10 is dead) (50 is max for rmvb's)
		if (conductor->age < 2)
			isJuv = true;
		else
			isAdult = true;

		num = getRandNum(0,MAX_NAMES-1);
		strcpy_s(conductor->name, bunnyNames[num].bName);

		num = getRandNum(0, MAX_COLORS - 1);
		conductor->colorNum = num;
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
	idx->last = conductor;

	// trying to adjust last, but it does not update outside of this function
	// investigate later

	//last = root;
	//while (last->next != NULL)
	//	last = last->next;


	
}



void giveBirth(indexes *idx, bStats *stats, int colorOfMom)
{
	void printBunnies(indexes *idx);

	stats->numBirths += 1;
	//int i;
	int num; // used for random numbers when assigning values to bunny
	bunny *conductor; // use this to naviate through the list
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
	printf("getting sex result is %c\n", conductor->sex);
	if (conductor->sex == 'M')
		isMale = true;
	if (conductor->sex == 'F')
		isFemale = true;
	if (conductor->sex != 'M' && conductor->sex != 'F' && conductor->sex != 'X')
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
	

	// bool for color counters go here in the future

	// update counts below
	//stats->totalBunnies += 1;

	//if (isMale)
	//{
	//	stats->numJuvMales += 1;
	//	stats->numMales += 1;
	//}
	//else if (isFemale)
	//{
	//	stats->numJuvFemales += 1;
	//	stats->numFemales += 1;
	//}
	//if (isaRMVB)
	//	stats->numRMVB += 1;

	printf("Bunny %s was born. ", conductor->name);
	printf("Sex: %c ", conductor->sex);
	printf("Age: %i ", conductor->age);
	printf("Color: %s ", conductor->color);
	printf("RMVB: %s\n", conductor->rmvb ? "true" : "false");
	printf("press RETURN to continue...\n");
	getchar();
	printBunnies(idx);
	

}

void printStats(bStats *stats)
{
	//bStats *stat;
	//stat = stats;

	printf("  BUNNY STATISTICS\n");
	printf("---------------------\n");
	printf("      Adult Males: %i\n",stats->numAdultMales);
	printf("    Adult Females: %i\n", stats->numAdultFemales);
	printf("\n");
	printf("   Juvenlie Males: %i\n", stats->numJuvMales);
	printf(" Juvenile Females: %i\n", stats->numJuvFemales);
	printf("\n");
	printf("      Total Males: %i\n", stats->numMales);
	printf("    Total Females: %i\n", stats->numFemales);
	printf("             RMVB: %i\n", stats->numRMVB);
	printf("    Total Bunnies: %i\n", stats->totalBunnies);
	printf("\n");
	printf("           Births: %i\n", stats->numBirths);
	printf("           Deaths: %i\n", stats->numDeaths);
	printf("\n");
	printf("Total turns taken: %i\n", stats->numTurns);
	printf("---------------------\n");
	printf("\n");
}



void printBunnies(indexes *idx)
{
	bunny *conductor;
	
	conductor = idx->first;
	//printf("Still Have Bunnies: %s\n", *p_stillHaveBunnies ? "true" : "false");
	printf("----------------------\n");
	while (conductor != NULL)
	{
		printf("  Name: %s", conductor->name);
		printf("   Sex: %c", conductor->sex);
		printf(" Color: %s", conductor->color);
		printf("   Age: %i", conductor->age);
		printf("  RMVB: %s\n", conductor->rmvb ? "** YES **" : "no");
		printf("----------------------\n");
		conductor = conductor->next;
	}
}

void killBunny(indexes *idx, bunny *killThisOne, bStats *stats, bool *p_stillHaveBunnies)
{
	stats->numDeaths += 1;
	// when bunny to kill is the first one
	if (idx->first == killThisOne)
	{
		if (killThisOne->next == NULL)
		{
			printf("Killing bunny %s, who is the FINAL bunny.\n", killThisOne->name);
			printf("All the bunnies are dead! Only ROOT exists now.\n");


			idx->first = idx->root;
			idx->first->next = NULL;

			*p_stillHaveBunnies = false; // game over!
			printBunnies(idx);
			return;
		}
		printf("Killing bunny %s, who is FIRST in the list of bunnies.\n", killThisOne->name);
		

		// copy next bunny to first bunny

		idx->first = idx->first->next; // does this replace the lines below?
		printBunnies(idx);

		//strcpy_s(idx->first->name, idx->first->next->name);
		//idx->first->age = idx->first->next->age;
		//idx->first->sex = idx->first->next->sex;
		//idx->first->colorNum = idx->first->next->colorNum;
		//strcpy_s(idx->first->color, idx->first->next->color);
		//idx->first->rmvb = idx->first->next->rmvb;
		//idx->first->row = idx->first->next->row;
		//idx->first->col = idx->first->next->col;

		killThisOne = idx->first->next;
		idx->last = idx->first; // does this make the last one correct? should only be 1 bunny left at this point

		if (idx->first->next != NULL)
		{
			idx->first->next = idx->first->next->next;
			
		}


		printStats(stats);
		printBunnies(idx);

		return;
	}



	struct bunny *prev = idx->root;

	printf("Killing bunny %s.\n", killThisOne->name);
	

	while (prev->next != NULL && prev->next != killThisOne)
		prev = prev->next;

	if (prev->next == NULL)
	{
		// printf("Can't find the bunny to be killed in the list.\n");
		return;
	}
	prev->next = prev->next->next;
	printBunnies(idx);


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
		if (conductor->age >= 10)
		{
			actionTaken = true;
			killThisOne = conductor;
			killBunny(idx, killThisOne, stats, p_stillHaveBunnies);

			if (idx->first == idx->root)
				return;

		}

		conductor = conductor->next; // move to next bunny

	}
	if (!actionTaken)
	{
		printf("No action taken. Here are the current stats.\n");
		printStats(stats);
		printBunnies(idx);
	}
	
}

void increaseAge(indexes *idx, bStats *stats)
{
	bunny *conductor;
	conductor = idx->first;

	while (conductor != NULL)
	{
		// increase ages for all bunnies
		conductor->age += 1;
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

		if (conductor->sex == 'M')
		{
			stats->numMales += 1;
			if (conductor->age > 1)
				stats->numAdultMales += 1;
			else
				stats->numJuvMales += 1;
		}

		if (conductor->sex == 'F')
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

}



void takeTurn(indexes *idx, bStats *stats, bool *p_stillHaveBunnies)
{
	bunny *conductor;

	int mColor;

	//system("cls");

	stats->numTurns += 1;
	printf("Start of turn # %i\n", stats->numTurns);
	printBunnies(idx);
	printStats(stats);

	printf("Now increasing age of all bunnies.\n");
	increaseAge(idx, stats);
	updateStats(idx, stats);
	printf("Stats after updating ages.\n");
	printStats(stats);

	printf("Checking for bunnies to kill.\n");
	checkForDeaths(idx, stats, p_stillHaveBunnies);
	updateStats(idx, stats);
	printf("Stats after killing bunnies...\n");
	printStats(stats);

	conductor = idx->first;

	if (stats->numAdultMales > 0 && stats->numAdultFemales > 0) // have to have at least 1 adult male and 1 adult female to have babies

	{
		while (conductor != NULL)
		{
			if (conductor->sex == 'F' && conductor->age > 2)
			{
				printf("Bunny %s Age: %i Sex: %c Color: %s is giving birth!\n", conductor->name, conductor->age, conductor->sex, conductor->color);
				mColor = conductor->colorNum;
				giveBirth(idx, stats, mColor);
				updateStats(idx, stats);
				printf("Stats after birth...\n");
				printStats(stats);
			}
			conductor = conductor->next;
		}
	}
	updateStats(idx, stats);
	updateLastBunny(idx);
	printf("\nPausing... Updating stats and last bunny. press any key for next turn.\n");
	getchar();
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

	//bunny *root;	// this is the start of the list. this record will never change and will have the name "ROOT"
	//bunny *first;
	//bunny *last;
	bunny *conductor;

	indexes *idx;

	bStats *stats;

	char board[MAX_BOARD_ROWS][MAX_BOARD_COLUMS]; // creates bunny board

	void killBunny(indexes *idx, bunny *conductor, bStats *stats, bool *p_stillHaveBunnies);
	void checkForDeaths(indexes *idx, bStats *stats, bool *p_stillHaveBunnies);
	void printBunnies(indexes *idx);
	bool isRMVB();
	char getRandomSex();
	void createRoot(indexes *idx);
	void updateLastBunny(indexes *idx);
	void addNewBunny(indexes *idx);
	// void initializeFirstBunnies(bunny *root, bunny *first, bunny *last, bStats *stats);
	void initializeFirstBunnies(indexes *idx, bStats *stats);
	void initializeStats(bStats *stats);
	void printStats(bStats *stats);
	void takeTurn(indexes *idx, bStats *stats, bool *p_stillHaveBunnies);
	void giveBirth(indexes *idx, bStats *stats, int colorOfMom);
	void increaseAge(indexes *idx, bStats *stats);
	//void updateStats(bunny *root, bunny *first, bStats *stats);
	void updateStats(indexes *idx, bStats *stats);

	stats = new bStats;

	bool haveBunnies = true;

	bool *p_stillHaveBunnies = &haveBunnies;

	idx = new indexes;



	initializeBoard(board);
	initializeStats(stats);

	// INITIALIZE THE ROOT RECORD

	//root = new bunny;    // create ROOT record at head of the list. This record will not change and be named ROOT. this will NOT be a bunny
	createRoot(idx);

	idx->first = idx->root; // first bunny record should start here. 
	idx->last = idx->root;
	idx->root->next = NULL; // 0 incdiates this is the end of the list

	//strcpy_s(idx->root->name, "ROOT");

	//idx->root = root;
	//idx->first = root;
	//idx->last = root;

	// END INITIALIZATION

	// ALL TESTING DONE BELOW HERE

	initializeFirstBunnies(idx, stats);
	printBunnies(idx);

	//giveBirth(idx, stats, 1);
	//updateStats(idx, stats);

	// idx->first = idx->root->next; // sets the first bunny to the record after ROOT

	conductor = idx->first;
	printf("5 BUNNIES IN OUR INITIAL LIST\n");

	printBunnies(idx);
	printStats(stats);

	i = 0;

	while (haveBunnies)
	{
		i++;
		printf("Turn %i:  \n", i);
		takeTurn(idx, stats, p_stillHaveBunnies);
	}
	printf("\n");

	printf("\n");
	printf("FINAL STATISTICS AND BUNNY LIST\n");
	printStats(stats);
	printBunnies(idx);



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

