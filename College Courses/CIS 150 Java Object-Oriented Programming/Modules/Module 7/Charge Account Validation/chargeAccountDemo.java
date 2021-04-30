/*Alex Kolar
*4/4/2013
*CIS150 Section 28951
*Charge Account Validation Demo
*Page 504
*/

import java.util.Scanner;

public class chargeAccountDemo
{
	public static void main(String[] args)
	{
		//create vars and constants
		int account, result;
		searchArray found;

		//create array(s)
		int[] accountNumbers = { 5658845, 4520125, 7895122, 8777541, 8451277, 1302650,
										8080152, 4562555, 5552012, 5050552, 7825877, 1250255,
										1005231, 6545231, 3852085, 7576651, 7881200, 4581002 };

		//create scanner object
		Scanner keyboard = new Scanner(System.in);

		//ask for an account number
		System.out.print("Enter a 7-digit account number: ");
		account = keyboard.nextInt();

		//search for that account number in the array
		result = searchArray.sequentialSearch(accountNumbers, account);

		//found = new searchArray;

		//if found, say it's found. same with opposite
		if (found == true)
		{
			System.out.println("Your account has been found. Welcome.");
		}
		else
		{
			System.out.println("Try another account number.");
		}
	}
}