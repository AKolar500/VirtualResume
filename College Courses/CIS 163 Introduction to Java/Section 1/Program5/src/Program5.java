/*Alex Kolar
 *Mr. R. B. Grover
 *CIS163
 *Section 26279
 *10/3/2011
 *Program 5 Methods
 */

/*This program allows one to make a theoretical triangle by demanding three random, but well-planned (in other words, user-chosen)
 * numbers from them.
 */
import java.util.*;
public class Program5 {

    public static void main(String[] args) {
    	Scanner input = new Scanner(System.in);
    	System.out.print("Type the lengths of each side of your triangle: ");
    		//allows the user to enter 3 values, each separated by a space or a line("enter" key)
    		double side1 = input.nextDouble();
    		double side2 = input.nextDouble();
    		double side3 = input.nextDouble();
    	if (isValid(side1, side2, side3))
    		System.out.println("The area that you seek is " + area (side1, side2, side3) + ".");
    	else
    		System.out.print("That's not a triangle. One side must be different than the other two sides, but not greater than them combined.");
    }
    //Checks if values truly form a triangle
    public static boolean isValid(double a, double b, double c){
    	if (a + b > c && b + c > a && a + c > b)
    		return true;
    	else
    		return false;
    }
    //Computes the triangle
    public static double area(double side1, double side2, double side3){
		double s = (side1 + side2 + side3)/2;
		return Math.sqrt(s*(s - side1)*(s - side2)*(s - side3));
    }
}
