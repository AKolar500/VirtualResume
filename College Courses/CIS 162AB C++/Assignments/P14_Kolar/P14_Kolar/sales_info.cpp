//P14 SalesInfo      
//Implementation file - sales_info.cpp - function defintions

#include "stdafx.h"

#include <iostream>      // cout and cin
#include "sales_info.h"  // SalesInfo

using namespace std;
 

//default constructor- the input functions should be called from here
SalesInfo::SalesInfo()
: SalesPerson()        //call constructor in base class 
{
	inputRate();
	inputQty();
}

//overloaded constructor - arguments assigned to members
//use base initialize list to call constructor in base class
SalesInfo::SalesInfo(int id, string fn, string ln,
	double rt, int qt)
	: SalesPerson(id, fn, ln)
{
	rate = rt;
	qty = qt;
}

//destructor
SalesInfo::~SalesInfo()
{
	cout << "SalesInfo   Object going out of scope. Id = "
		<< salesPersonId << endl;
}


//Student needs to complete the next 4 functions.
//Accessors to set values in private variables
void SalesInfo::setRate(double rt)
{
	rate = rt;
}


void SalesInfo::setQty(int qt)
{
	qty = qt;
}


//Accessors to return values in private variables
double SalesInfo::getRate()
{
	return rate;
}

int SalesInfo::getQty()
{
	return qty;
}


void SalesInfo::inputRate()
{//Normally set and input functions would include validation and would throw an exception if an error was found.
	do
	{
		cout << "Enter a bonus rate between $5.00 and $10: ";
		cin >> rate;

		if (rate < 5.0 || rate > 10.00)
			cout << "Error: The rate must be between $5.00 and $10.00. "
			<< "Try again...\n\n";

	} while (rate < 5.0 || rate > 10.00);
	return;
}


void SalesInfo::inputQty()
{
	do
	{
		cout << "Enter a quantity between 0 and 200:       ";

		cin >> qty;

		if (qty < 0 || qty > 200)
			cout << "Error: The quantity must be between 0 and 200. "
			<< "  Try again...\n\n";

	} while (qty < 0 || qty > 200);
	return;
}

// End of implementation file  sales_info.cpp
