

import java.io.FileNotFoundException;
import java.io.IOException;

/**
 * 
 * @author Bill Robertson
 *
 */
public class TestClass {

	/**
	 * @param args
	 */
	public static void main(String[] args) throws FileNotFoundException, IOException {
		// TODO Auto-generated method stub
		
		//test data for binary search
		int[] anArray = { 
			    100, 200, 300,
			    400, 500, 600, 
			    700, 800, 900, 1000
			};

        //original string
        String str = "Sony is going to introduce Internet TV soon";
        System.out.println("Original String: " + str);


        //reversed string using Stringbuffer
        String reverseStr = new StringBuffer(str).reverse().toString();
        System.out.println("Reverse String in Java using StringBuffer: " + reverseStr);


        //iterative method to reverse String
        reverseStr = reverse(str);
        System.out.println("Reverse String in Java using Iteration: " + reverseStr);

        //recursive method to reverse String 
        reverseStr = reverseRecursively(str);
        System.out.println("Reverse String in Java using Recursion: " + reverseStr);
        
        //BinarySearch on test data array
        System.out.println("Looking for value 100 in test data array");
        int index = customBinarySearch(anArray,100,0,anArray.length);
        System.out.println("Found at Indexs:" + index);

    }


    public static String reverse(String str) {
        StringBuilder strBuilder = new StringBuilder();
        char[] strChars = str.toCharArray();

        for (int i = strChars.length - 1; i >= 0; i--) {
            strBuilder.append(strChars[i]);
        }

        return strBuilder.toString();
    }


    public static String reverseRecursively(String str) {
        if (str.length() < 2) {
            return str;
        }

        return reverseRecursively(str.substring(1)) + str.charAt(0);
    }

    public static int customBinarySearch(int[] a, int key, int min, int max)
    {
    	if (max <= min) //checking for key not in the array
    	{
    		return -1;
    	}
    	while (min <= max)
    	{
    		int mid = (min +max) /2;
    		if (a[mid] == key)
    		{
    			return mid;
    		}
    		else if (a[mid] > key)
    		{
    			return customBinarySearch(a,key,min, mid -1);
    		}
    		else if (a[mid] < key)
    		{
    			return customBinarySearch(a,key,mid -1 , max);
    		}
    	}
    	return -1; //Code should never reach this.
    }
    
}
