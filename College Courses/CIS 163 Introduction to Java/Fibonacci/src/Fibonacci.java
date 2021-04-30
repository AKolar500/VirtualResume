/*
 * Copyright (c) 2000 David Flanagan.  All rights reserved.
 * This code is from the book Java Examples in a Nutshell, 2nd Edition.
 * It is provided AS-IS, WITHOUT ANY WARRANTY either expressed or implied.
 * You may study, use, and modify it for any non-commercial purpose.
 * You may distribute it non-commercially as long as you retain this notice.
 * For a commercial use license, or to purchase the book (recommended),
 * visit http://www.davidflanagan.com/javaexamples2.
 */

/**
 * This program prints out the first 20 numbers in the Fibonacci sequence. Each
 * term is formed by adding together the previous two terms in the sequence,
 * starting with two of the same term. If you want to change the base number, change
 * the values of n0 and n1 simultaneously in the third line of code. The values must be the same
 * or you will get an incorrect Fibonacci sequence.
 */
public class Fibonacci {
  public static void main(String[] args) {
    int n0 = 1, n1 = 1, n2; // Initialize variables. You can change the starting value of the sequence by changing the n0 and n1 values. They must remain simultaneous.
    System.out.print(n0 + ", " + n1 + ", "); // Print first and second terms of the series

    for (int i = 0; i < 18; i++) // Loop for the next 18 terms
	 {
    	n2 = n1 + n0; // Next term is sum of previous two
      System.out.print(n2 + ", "); // Print it out
      n0 = n1; // First previous becomes 2nd previous
      n1 = n2; // And current number becomes previous
    }
    System.out.println(); // Terminate the line
  }
}

