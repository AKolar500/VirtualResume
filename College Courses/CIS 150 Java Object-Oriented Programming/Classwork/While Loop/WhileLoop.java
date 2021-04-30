//This program demonstrates the While loop.
public class WhileLoop
{
	public static void main(String[] args)
	{
		//declare variables
		int number = 1; //Every variable defaults to 0, so I changed it to 1 to make it unique.
		int sum = 0;
		
		while (number <= 5) //Test if number is < or = 5
		{
			//If the test returns true, execute the following code.
			sum += number; //sum = the sum of every value of number.
			System.out.println("Hello " + number); //Print Hello and the current value of number.
			number++; //Increment number once (the ++ adds 1 to the variable specified before or after it).
		}
		//When the test returns false, the while loop is terminated, and the code resumes.
		System.out.println("That's all, folks! " + sum); //Print the value of sum, which should be 15.
	}
}