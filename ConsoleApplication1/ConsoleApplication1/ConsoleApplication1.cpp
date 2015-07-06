// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <conio.h>

using  namespace std;

/*class Date {
public:
	Date(char *string);
	void DisplayMonth();
	void UpdateTheMyString(char *string);
	~Date();
private:
	char *sMyStringPtr;
};

Date::Date(char *string) {
	int iLengthOfString;
	iLengthOfString = strlen(string) + 1;
	sMyStringPtr = new char[iLengthOfString];
	strcpy(sMyStringPtr, string);
}

void Date::DisplayMonth()
{
	cout << sMyStringPtr << endl;
	_getch();
}

void Date::UpdateTheMyString(char *string) {
	char *sTmpPtr;

	int iLengthOfString;
	iLengthOfString = strlen(string) + 1;

	sTmpPtr = new char[iLengthOfString];
	strcpy(sTmpPtr, string);

	delete sMyStringPtr;

	sMyStringPtr = sTmpPtr;
}

Date::~Date()
{
	delete sMyStringPtr;
}

void main()
{
	Date MyMonth("Julho");
	MyMonth.DisplayMonth();
	MyMonth.UpdateTheMyString("Agosto");
	MyMonth.DisplayMonth();
}*/