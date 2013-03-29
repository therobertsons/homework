import static org.junit.Assert.*;
import junit.framework.Assert;

import org.junit.Test;


public class TestClassTest {

	@Test
	public void testReverse() {
		String test1 = "brown fox is jumping!";
		String reversedtest1 = TestClass.reverse(test1);
		Assert.assertEquals("!gnipumj si xof nworb", reversedtest1);
		String reversedtwice = TestClass.reverse(reversedtest1);
		Assert.assertEquals(test1, reversedtwice);
		
	}

	@Test
	public void testReverseRecursively() {
		String test1 = "brown fox is jumping!";
		String reversedtest1 = TestClass.reverseRecursively(test1);
		Assert.assertEquals("!gnipumj si xof nworb", reversedtest1);
		String reversedtwice = TestClass.reverseRecursively(reversedtest1);
		Assert.assertEquals(test1, reversedtwice);
	}
	
	@Test
	public void testCustomBinarySearch() {
		//test data for binary search
		int[] anArray = { 
			    100, 200, 300,
			    400, 500, 600, 
			    700, 800, 900, 1000
			};
		
		int index = TestClass.customBinarySearch(anArray, 500, 0, anArray.length);
		Assert.assertEquals(4,index);
		
		index = TestClass.customBinarySearch(anArray, 1001, 0, anArray.length);
		Assert.assertEquals(-1,index);
	}

}
