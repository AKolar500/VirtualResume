/*Alex Kolar
 *Mr. R. B. Grover
 *10/11/2011
 *CIS 163
 *Section 26279
 *Program 6 Array
 */

public class Program6 {

    public static void main(String[] args) {
    	int[] nums = createArray();
    	System.out.println("Random array: ");
    	displayArray(nums);
    	int[] counts = countNum(nums);
    	displayCounts(counts);
    	int min = least(counts);
    	System.out.println("Least: "+ min);
    	displayLeast(nums, min);
    	}
    public static int[] createArray() {
    	int[] nums = new int[100];
    	for (int i = 0; i < nums.length; i++)
    		nums[i] = (int)(Math.random() * 10);
    	return nums;
    }
    public static int[] countNum(int[] nums) {
    	int[] count = new int[10];
    	for (int i = 0; i < nums.length; ++i)
    		count [nums[i]] ++;
    	return count;
    }
    public static int least(int[] leasts) {
    	int min = 0, i;
    	for (i = 1; i < leasts.length; i++)
    		if (leasts[i] < leasts[min])
    			min= i;
    	return min;
    }
    public static void displayArray(int[] nums){
    	for(int i = 0; i < nums.length; i++)
    		if((i+1)%10==0)
    			System.out.println(nums[i]+"\t");
    		else
     			System.out.print(nums[i]+"\t");
    }
    public static void displayCounts(int[] count){
    	for(int i = 0; i < count.length; i++)
   			System.out.println(count[i]+"\t" +i+"'s" );
    }

    public static void displayLeast(int[] nums, int min){
    	for (int i = 0; i < nums.length; i++)
    		if (nums[i] == min)
    			System.out.println("Location " + i);
    }
}
