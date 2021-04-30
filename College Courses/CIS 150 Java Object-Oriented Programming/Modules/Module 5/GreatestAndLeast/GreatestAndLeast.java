/*Alex Kolar
*3/7/2013
*CIS150AB Section 28951
*Greatest And Least
*/

import java.util.Scanner;

public class GreatestAndLeast
{
	public static void main(String[] args)
	{
		int value, //the values that the user inputs
			largestValue,
			smallestValue;

		//Create the Scanner
		Scanner valueInput = new Scanner(System.in);

		//Print the instructions for the user
		System.out.println("Enter a SHORT list of integers.");
		System.out.println("The integers can be of any size, but none can be -99.");
		System.out.println("Enter -99 when you are finished.");

		//Get the first number.
		System.out.println("Enter an integer below.");
		value = valueInput.nextInt();
		//assign it to both the largest and smallest.
		largestValue = value;
		smallestValue = value;


		//Get all the other numbers the user decides to enter. This should be a loop.
		while (value != -99)
		{
			System.out.println("Enter an integer, or -99 to end: ");
			value = valueInput.nextInt();
			if (value != -99 && value > largestValue)
				largestValue = value;
			if (value != -99 && value < smallestValue)
				smallestValue = value;
		}

		//Display largest and smallest numbers
		if (smallestValue == -99)//it doesn't matter whether you test the largest or smallest numbers here. Just don't use "value".
		{
			System.out.println("You did not enter a valid number. I'll give you one last chance. Try again.");

			/*THIS IS THE SECOND CHANCE RUN, DEDICATED TO USERS WHO ARE PARTICULARLY DENSE.
			*REAL-WORLD PROGRAMMERS HAVE TO ACCOUNT FOR PEOPLE LIKE THAT.
			*SORRY IF THE CODE SEEMS REDUNDANT. THAT'S BECAUSE IT IS.
			*SORRY IF YOU ARE IRRITATED BY THE FACT THAT YOU HAVE TO ENTER A WRONG VALUE TWICE.
			*I WANTED TO AMUSE YOU AND HELP PREPARE MYSELF FOR A REAL-WORLD SCENARIO, BOTH AT THE SAME TIME.
			*/

			//Get the first number.
			System.out.println("Enter an integer below.");
			value = valueInput.nextInt();
			//assign it to both the largest and smallest.
			largestValue = value;
			smallestValue = value;


			//Get all the other numbers the user decides to enter. This should be a loop.
			while (value != -99)
			{
				System.out.println("Enter an integer, or -99 to end: ");
				value = valueInput.nextInt();
				if (value != -99 && value > largestValue)
					largestValue = value;
				if (value != -99 && value < smallestValue)
					smallestValue = value;
			}

			//Display largest and smallest numbers
			if (smallestValue == -99)//it doesn't matter whether you test the largest or smallest numbers here. Just don't use "value".
			{
				System.out.println("You have failed me yet again. You must be punished for your lack of vision. Goodbye.");
				/*System.out.println();
				*System.out.println("TO ANSWER THE QUESTIONS YOU MAY BE ASKING RIGHT NOW:");
				*System.out.println("Real-world programmers have to account for people who are particularly dense.");
				*System.out.println("Sorry if the code seems redundant. That's because it is.");
				*System.out.println("Sorry if you are irritated by the fact that you have to enter a wrong value twice.");
				*System.out.println("I wanted to amuse you and help prepare myself for a real-world scenario, both at the same time.");
				*/
			}
			else
			{
				System.out.println("The largest value is: " + largestValue);
				System.out.println("The smallest value is: " + smallestValue);
			}
		}
		else
		{
			System.out.println("The largest value is: " + largestValue);
			System.out.println("The smallest value is: " + smallestValue);
		}
	}
}