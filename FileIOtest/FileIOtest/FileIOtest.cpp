// FileIOtest.cpp : Defines the entry point for the console application.
/* C++ Programming, Example answer, Exercise 5, Sheet 5  */

/* Author: William Knottenbelt
Program last changed: 28 September 2013    */

/* This program prints a table of character occurrences
in the file "Sheet5Ex5.cpp"                            */
/*
https://www.doc.ic.ac.uk/~wjk/C++Intro/RobMillerE5.html

Question 5
Write a program which prints a table listing the number of occurrences of the lower - case characters 'a' to 'z' in the file "Sheet5Ex5.cpp". 
(Save your program in a file of this name so that you can test it on itself.) Write your program as though your computer is short of 
memory - you should declare only one variable of type "ifstream", one variable of type "char", and two variables of type "int".
The program should produce output such as the following :

CHARACTER           OCCURRENCES

a                   38
b                   5
c                   35
d                   7
e                   58
f                   8
g                   8
h                   21
i                   32
j                   0
k                   0
l                   19
m                   16
n                   34
o                   22
p                   8
q                   0
r                   48
s                   17
t                   61
u                   15
v                   0
w                   4
x                   4
y                   0
z                   1

*/
#include "stdafx.h"
#include <iostream>
#include <fstream>
using namespace std;

int count_character(char letter);
int main()
{
	char letter;

	cout.setf(ios::left);

	/* Print table heading */
	cout.width(19);
	cout << "CHARACTER";

	cout << "OCCURRENCES" << endl << endl;

	/* print table of characters */
	for (letter = 'a'; letter <= 'z'; letter++) {
		cout.width(19);
		cout << letter;
		cout << count_character(letter) << endl;
	}

	return 0;
}

int count_character(char letter) {

	char character;
	ifstream in_stream;

	in_stream.open("Sheet5Ex5.cpp");
	in_stream.get(character);

	int count = 0;
	while (!in_stream.fail()) {
		if (character == letter)
			count++;
		in_stream.get(character);
	}
	in_stream.close();

	return count;
}