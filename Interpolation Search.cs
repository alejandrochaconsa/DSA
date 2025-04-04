// Interpolation Search

// improvement over binary search best used for "uniformly" distributed data
// "guesses" where a value might be based on calculated probe results
// if probe is incorrect, search area is narrowed, and a new probe is calculated
// average case: O(log(log(n)))
// worst case: O(n) [values increase exponentially]

//Source: https://www.youtube.com/watch?v=YSVS5GG1JuI
//Fiddle: https://dotnetfiddle.net/lccGXN

// Formula:
// int probe = low + (high - low) * (value - array[low]) / 
// 					    (array[high] - array[low]);


using System;
					
public class Program
{
	public static void Main()
	{
		int[] array = {1,2,4,8,16,32,64,128,256};
		
		var index = InterpolationSearch(array, 128);
		
		if(index != -1){
			Console.WriteLine("Element found at index: " + index);
		}
		else{
			Console.WriteLine("Element not found");
			
		}
	}
	
	public static int InterpolationSearch(int[] array, int valueToBeSearched){
		
		int high = array.Length -1;
		int low = 0;
		
		while(valueToBeSearched >= array[low] && valueToBeSearched <= array[high] && low <= high){
			int probe = low + (high - low) * (valueToBeSearched - array[low]) / (array[high] - array[low]);
			Console.WriteLine("Probe = " + probe);
			if(array[probe] == valueToBeSearched){
				return probe;
			}
			else if(array[probe] < valueToBeSearched){
				low = probe + 1;
			}
			else if(array[probe] > valueToBeSearched){
				high = probe - 1;
			}
		}
	
		return -1;
	}
}