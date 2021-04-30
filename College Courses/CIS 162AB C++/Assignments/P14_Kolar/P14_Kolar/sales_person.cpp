//P14 SalesPerson  
//Implementation file - sales_person.cpp - function defintions

#include "stdafx.h"

#include <iostream>        // cout and cin
#include "sales_person.h"  // SalesPerson

using namespace std;


//Functions for class SalesPerson include:

SalesPerson::SalesPerson()
{
	inputSalesPersonId();
	inputFirstName();
	inputLastName();
}

//overloaded constructor
SalesPerson::SalesPerson(int id, string fn, string ln)
{
	salesPersonId = id;
	firstName = fn;
	lastName = ln;
}

//Destructor function definition is provided below
SalesPerson::~SalesPerson()
{
	cout << "\nSalesPerson Object going out of scope. Id = "
		<< salesPersonId << endl;
	return;
}

//set accessors
void SalesPerson::setSalesPersonId(int id)
{
	salesPersonId = id;
}
void SalesPerson::setFirstName(string fn)
{
	firstName = fn;
}
void SalesPerson::setLastName(string ln)
{
	lastName = ln;
}

//get accessors
int SalesPerson::getSalesPersonId()
{
	return salesPersonId;
}
string SalesPerson::getFirstName()
{
	return firstName;
}
string SalesPerson::getLastName()
{
	return lastName;
}

//input accessors
void SalesPerson::inputSalesPersonId()
{
	cout << "Enter Sales Person ID (1000 - 9999): ";
	cin >> salesPersonId;
}
void SalesPerson::inputFirstName()
{
	cout << "Enter First Name without spaces: ";
	cin >> firstName;
}
void SalesPerson::inputLastName()
{
	cout << "Enter Last Name without spaces: ";
	cin >> lastName;
}
// End of implementation file  sales_person.cpp
