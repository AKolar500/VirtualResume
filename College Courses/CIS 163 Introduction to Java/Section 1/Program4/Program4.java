/**
 *Alex Kolar
 *CIS163
 *Section 26279
 *9/29/2011
 *Program 4: Loops
 */

public class Program4 {

    public static void main(String[] args) {
    	int kilo = 1;
    	double cpound;
    	int pound = 20;
    	double ckilo;
    		System.out.println("  OddK   OddP   Poundx5   Kilox5");
    	for ( ; kilo <= 199; kilo+=2, pound+=5){
    		cpound = (int)(kilo * 2.2 * 10.0) / 10.0;
    		ckilo = (int)(pound / 2.2 * 10.0) / 10.0;
    		System.out.println("  " + kilo + "      " + cpound + "    " + pound + "        " + ckilo);

    	}
    //	for ( ; oddp <= 400.0; oddp+=2){
    //			System.out.println("  " + oddp);
    //	}
    }
}
