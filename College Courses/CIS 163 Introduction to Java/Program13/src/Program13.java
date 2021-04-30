/**
 * @(#)Program13.java
 *
 * Program13 application
 *
 * @author
 * @version 1.00 2011/4/21
 */

public class Program13 {

    public static void main(String[] args) {
    	int[] array = new int[10];
    	int index = 99;

    	try{
    		System.out.println(array[index]);
    	}
    	catch(ArithmeticException e){
    		System.out.println("ArithmeticException catch: " + e.getMessage());
    	}
    	// ArrayIndex can be substituted with Index
    	catch(ArrayIndexOutOfBoundsException e){
    		System.out.println("Index is out of bounds.");
    	}
    	catch(Exception e){
    		System.out.println("You suck at programming.");
    	}
    	//System.out.println("z is "+z);
    }
}
