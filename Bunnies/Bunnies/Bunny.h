#pragma once

#include <string>
#include <vector>
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

	// public static variables used for list of bunnies and statistics
	static int numBunnies;


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
