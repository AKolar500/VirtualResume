/**
 * @(#)Assignment4-Kolar.java
 *
 * Assignment4-Kolar application
 *
 * @author Alex Kolar
 * @version 1.00 2013/12/1
 */
import java.util.Scanner;

public class Assignment4Kolar {

    //create a scanner to record the user's input
    Scanner keyboard = new Scanner(System.in);

    int static userVal1;
    int static userVal2;

    int static userSum, userDifference;
    int static userProduct;
    double static userQuotient;

    double static userFloatingPoint;

    public static void main(String[] args) {

		//get first and second values
    	userVal1 = getFirstValue();
    	userVal2 = getSecondValue();

		//calculate the sum
    	userSum = addNumbers(userVal1, userVal2);

		//calculate the difference
		userDifference = subtractNumbers(userVal1, userVal2);

		//calculate the product
		userProduct = multiplyNumbers(userVal1, userVal2);

		//calculate the quotient
		userQuotient = divideNumbers(userVal1, userVal2);

    	//display results
    	System.out.println("Your numbers were: "+userVal1+" and "+userVal2);
    	System.out.println("Your sum is: "+userSum);
    	System.out.println("Your difference is: "+userDifference);
    	System.out.println("Your product is: "+userProduct);
    	System.out.println("Your quotient is: "+userQuotient);
    }

    public static int getFirstValue()
    {
    	//double userVal1;

    	//Get the first number
		System.out.print("Enter the base number: ");
		userVal1 = keyboard.nextInt();

		return userVal1;
    }

    public static int getSecondValue()
    {
    	//double userVal2;

    	//Get the first number
		System.out.print("Enter the second number: ");
		userVal2 = keyboard.nextInt();

		return userVal2;
    }

    //add the numbers
    public static int addNumbers(int userVal1, int userVal2)
    {
    	int sum;

    	//add
    	sum = userVal1 + userVal2;

    	//return the sum
    	return sum;
    }

	//subtract the numbers
	public static int subtractNumbers(int userVal1, int userVal2)
	{
		int difference;

		//subtract
		difference = userVal1 - UserVal2;

		//return the difference
		return difference;
	}

	//multiply the numbers
	public static int multiplyNumbers(int userVal1, int userVal2)
	{
		int product;

		//multiply
		product = userVal1 * userVal2;

		//return the product
		return product;
	}

	//divide the numbers
	public static double divideNumbers(int userVal1, int userVal2)
	{
		double quotient;

		//divide
		quotient = userVal1 / userVal2;

		//return the quotient
		return quotient;
	}
}
