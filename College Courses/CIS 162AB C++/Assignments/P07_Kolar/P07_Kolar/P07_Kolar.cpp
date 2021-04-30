//P07 Using the Debugger - Alex Kolar
//
// This program is used by customers to determine what the cost
// of their order would be based on the price and quantity ordered.

#include "stdafx.h"
#include <iostream>
using namespace std;


/*int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}*/

//Function Prototypes
void getPrice(double& price); //call-by-reference
void getQuantity(int& quantity); //call-by-value, changed to call-by-reference
double calcCost(double cost, int quantity);
double calcTax(double subtotal, double taxRate);

//Declare the global constants
const double TAX_RATE = 0.05;

//I put this here in order to run the program. It tells me that this variable
//is uninitialized.
int quantity;

void main()
{
	//Declare the local constants
	const double SHIPPING = 10.00;
	
	//Declare local variables
	double price, subtotal, salesTax, total;
	int openWindow;
	
	//Set the decimal point to 2 positions
	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);
	cout << "P07 – Alex Kolar \n\n";
	
	//Get and validate values
	getPrice(price);
	getQuantity(quantity);
	
	//Calculate amounts
	subtotal = calcCost(price, quantity);
	salesTax = calcTax(subtotal, TAX_RATE);
	total = subtotal + salesTax + SHIPPING;
	
	//Display the results
	cout << endl
		<< "Price: \t" << price << endl
		<< "Quantity: \t" << quantity << endl
		<< "Subtotal: \t" << subtotal << endl
		<< "Sales Tax:\t" << salesTax << " at " << TAX_RATE << endl
		<< "Shipping: \t" << SHIPPING << endl
		<< "Total Due:\t" << total << endl;
	cout << "\nThank you!\n\n";

	//code for keeping window open
	cout << "Enter an integer, then press enter: ";
	cin >> openWindow;

	return;
} // end of main

//Function Definitions

void getPrice(double& price)
{
	do
	{
		cout << "Enter a value between $5 and $15.00 for the price: ";
		cin >> price;
	} while (price < 5 || price > 15);
	cout << endl;
	return;
}

void getQuantity(int& quantity)
{
	do
	{
		cout << "Enter a value between 1 and 50 for the quantity: ";
		cin >> quantity;
	} while (quantity < 1 || quantity > 50);
	return;
}

double calcCost(double price, int quantity)
{
	double subtotal;
	subtotal = price * quantity;
	return (subtotal);
}

double calcTax(double subtotal, double taxRate)
{
	double amount;
	amount = subtotal * taxRate;
	return (amount);
}
//end of program

//12. (Answer)
/*The getQuantity function does not return any value because it is void. In order for it to return anything, the values
it needs to return must be called by reference.*/
