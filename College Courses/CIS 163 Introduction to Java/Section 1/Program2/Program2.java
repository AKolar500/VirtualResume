/*Alex Kolar
 *9/14/2011
 *Mr. R. Grover
 *CIS163
 *Section 26279
 *Program 2
 */

import java.util.Scanner;
public class Program2 {

    public static void main(String[] args) {

    	// Create scanner
    	Scanner input = new Scanner(System.in);
    	//Enter feet
    	System.out.print("Feet: ");
    	double feet = input.nextDouble();
    	//Compute meters
    	double meters = feet * 0.3048;
    	System.out.println("Meters: " + meters);
    }
}
