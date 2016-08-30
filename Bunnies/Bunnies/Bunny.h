#pragma once

#include <string>
#include <vector>
#include <time.h>   // required to generate random numbers
#include <stdlib.h> // required by srand

using namespace std;



// Bunny class declaration
class Bunny
{
private:
	string name;
	int    age;
	char   sex;
	int    colorNum;
	string color;
	int    row;
	int    col;


public:
	// constructor with default values
	Bunny(string name = "NEW", int age = 0, char sex = 'f', int colorNum = 0, string color = "brown", int row = 0, int col = 0);

	// destructor
	~Bunny();

	// public static variables used for list of bunnies and statistics
	static int numBunnies;

	// structure for names
	struct bunnyNameList
	{
		string bunnyName;
	};

	const struct bunnyNameList bNames[14] =
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
		{"Tashi"},
		{"Jason"},
		{"Harry"},
		{"Russell"},
		{"Jessica"}
	};

	// public getters
	string getName() const;
	int getAge() const;
	char getSex() const;
	int getColorNum() const;
	string getColor() const;
	int getRow() const;
	int getCol() const;

	// public setters
	void setName(string name);
	void setAge(int age);
	void setSex(char sex);
	void setColorNum(int colorNum);
	void setColor(string color);
	void setRow(int row);
	void setCol(int col);

	// public functions
	void increaseAge();
	void printBunny() const;
	void printAllStats() const;
	int getRandomNum(int min, int max);
	string getRandomName();
	char getRandomSex();


};
// Implementation below

// constructor
Bunny::Bunny(string name, int age, char sex, int colorNum, string color, int row, int col)
{
	this->name = name;
	this->age = age;
	this->sex = sex;
	this->colorNum = colorNum;
	this->color = color;
	this->row = row;
	this->col = col;
}

Bunny::~Bunny()
{
}

// public static variable definitions and initializations
int Bunny::numBunnies = 0;



// public getters
string Bunny::getName() const {
	return this->name;
}

int Bunny::getAge() const {
	return this->age;
}

char Bunny::getSex() const {
	return this->sex;
}

int Bunny::getColorNum() const {
	return this->colorNum;
}

string Bunny::getColor() const {
	return this->color;
}

int Bunny::getRow() const {
	return this->row;
}

int Bunny:: getCol() const {
	return this->col;
}

// public setters
void Bunny::setName(string name) {
	this->name = name;
}

void Bunny::setAge(int age) {
	this->age = age;
}

void Bunny::setSex(char sex) {
	this->sex = sex;
}

void Bunny::setColorNum(int colorNum) {
	this->colorNum = colorNum;
}

void Bunny::setColor(string color) {
	this->color = color;
}

void Bunny::setRow(int row) {
	this->row = row;
}

void Bunny::setCol(int col) {
	this->col = col;
}

// public functions
void Bunny::increaseAge() {
	++age;
}

void Bunny::printBunny() const {
	cout << "Name: " << name;
	cout << " Age: " << age;
	cout << " Sex: " << sex;
	cout << " colorNum: " << colorNum;
	cout << " Color: " << color;
	cout << " Coords: " << row << "," << col;
	cout << endl;
}

void Bunny::printAllStats() const {
	cout << "TOTAL BUNNIES: " << numBunnies;
	cout << endl;
}
int Bunny::getRandomNum(int min, int max)
{
	return min + (rand() % (int)(max - min + 1));
}

char Bunny::getRandomSex()
{
	int min, max;
	int sexNum; // 0 or 1
	char sexChar; // used to return the sex M or F is older than 1 or m, f if aged 0 or 1

	min = 0; // (F)emale
	max = 1; // (M)ale

	// WRITE SEPARATE FUNCTION TO DETERMINE SEX BASED ON AGE i.e. updateSex

	sexNum = Bunny::getRandomNum(min, max);

	if (sexNum == 0)
		sexChar = 'F';
	else
		sexChar = 'M';

	if (age < 2)
	{
		if (sex == 'F')
			sexChar = 'f';
		else
			sexChar = 'm';
	}
	return sexChar;
}

string Bunny::getRandomName()
{
	int min, max;
	int nameNum;
	const int MAX_NUM_NAMES = 14;

	min = 0;
	max = MAX_NUM_NAMES;

	nameNum = min + (rand() % (int)(max - min + 1));

	return Bunny::bNames[nameNum].bunnyName;

}