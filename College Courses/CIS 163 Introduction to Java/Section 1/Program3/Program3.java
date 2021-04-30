/*Alex Kolar
 *CIS 163
 *Mr. R. Grover
 *Section 26279
 *9/21/11
 */
import java.util.Scanner;
public class Program3 {

    public static void main(String[] args) {
		int month;
		int days;
    	int year;
    	// Creates Scanner
    	Scanner input = new Scanner(System.in);
    	System.out.print("What year is it? ");
    	year = input.nextInt();
    	System.out.print("What month is it? ");
    	month = input.nextInt();

    	switch (month){
    		case 1: //January
    		case 3: //March
    		case 5: //May
    		case 7: //July
    		case 8: //August
    		case 10: //October
    		case 12: days=31;
    			break;
    		case 4: //April
    		case 6: //June
    		case 9: //September
    		case 11: days=30;
    			break;
    		case 2: //February
    			if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    				days=29;
    			else
    				days=28;
    			break;
    		default: System.out.println("That's not a month. Get a calendar and try again.");
    				days=0;
    	}
		System.out.println("That month has " + days + " days.");
    }
}
