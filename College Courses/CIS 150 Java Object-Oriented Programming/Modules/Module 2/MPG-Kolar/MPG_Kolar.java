/*
 *Programmer: Alex Kolar
 *Date: 1/28/2013
 *Class: CIS150AB 28951
 *Miles-Per-Gallon
 */

import java.util.Scanner;

public class MPG_Kolar
{
	public static void main(String[] args)
	{
		double gallons;		//gallons of fuel used
		double miles;			//miles driven
		double milesPerGallon;	//miles per gallon

		//Create a scanner to record the user's keyboard input
		Scanner keyboard = new Scanner(System.in);

		//Get the miles driven. (INPUT)
		System.out.print("How many miles did you drive? ");
		miles = keyboard.nextDouble();

		//Get the gallons of fuel used
		System.out.print("How many gallons of gas did you use? ");
		gallons = keyboard.nextDouble();

		//Calculate the miles per gallon. (Process)
		milesPerGallon = miles / gallons;

		//Display the miles per gallon. (Output)
		System.out.printf("Your MPG is: %,.1f\n", milesPerGallon);
	}
}