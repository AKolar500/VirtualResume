/*Alex Kolar
*3/21/2013
*CIS150AB Section 28951
*Carpet Calculator Demo
*/

//This project is similar to the Instructor, Textbook, Course, CourseDemo project. It can be found in the student data files.

import java.util.Scanner;

public class carpetCalculatorDemo
{
	public static void main(String[] args)
	{
		final double CARPET_PRICE = 8.0; //constant

		double length, width, totalPrice;
		roomDimension area; //the area of the room
		roomCarpet room;

		//create the scanner for user input
		Scanner keyboard = new Scanner(System.in);

		//get length
		System.out.print("Enter the length (in feet): ");
		length = keyboard.nextDouble();

		//get width
		System.out.print("Enter the width (in feet): ");
		width = keyboard.nextDouble();

		//create a roomDimension instance
		area = new roomDimension(length, width);

		//create a roomCarpet instance
		room = new roomCarpet(area, CARPET_PRICE);

		//get the total cost per square foot
		System.out.println(area);
		System.out.println(room);
		System.out.println("The total cost is " + "$" + room.getTotalCost());
	}
}