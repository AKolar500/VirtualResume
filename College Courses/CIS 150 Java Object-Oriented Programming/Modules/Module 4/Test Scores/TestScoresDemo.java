/*Alex Kolar
*2/14/2013
*CIS150AB Section 28951
*Test Scores Driver
*/

import java.util.Scanner; //Necessary for the scanner class.

public class TestScoresDemo
{
	public static void main(String[] args)
	{
		double test1, //Score #1
			test2, //Score #2
			test3, //Score #3
			average; //Average score
			
		//char LetterGrade; //Letter Grade

		//
		Scanner keyboard = new Scanner(System.in);

		System.out.println("This program averages 3 test scores.\nIt also gives you the letter grade for the average.");

		//Ask the user for input.
		System.out.println("Enter the first test score: ");
		test1 = keyboard.nextDouble();
		System.out.println("Enter the second test score: ");
		test2 = keyboard.nextDouble();
		System.out.println("Enter the third test score: ");
		test3 = keyboard.nextDouble();

		TestScores scores = new TestScores (test1, test2, test3);
		//Call the get average and get letter grade methods.
		System.out.println("The Average is " + scores.getAverage());
		System.out.println("The Average Letter Grade is " + scores.getLetterGrade());

	}
}