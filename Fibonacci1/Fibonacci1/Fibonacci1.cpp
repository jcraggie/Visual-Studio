// Fibonacci1.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	const int N = 25;

	int Fib[N];

	for (int i = 0; i < N; i++)
	{
		if (i == 0) Fib[i] = 0;
		else if (i == 1) Fib[i] = 1;
		else Fib[i] = Fib[i - 1] + Fib[i - 2];
	}

	for (int i = 0; i < N; i++)
		cout << "Fib[" << i << "] = " << Fib[i] << endl;

	return (0);
}