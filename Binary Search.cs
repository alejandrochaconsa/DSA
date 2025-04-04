// Binary search

// Search algorithm that finds the position of a target value within a sorted array. Half of the array is eliminated during each "step”.
// Formula to find the middle: int middle = low + (high - low) / 2;
// .NET Fiddle: https://dotnetfiddle.net/w2xkas
// LeetCode: https://leetcode.com/problems/first-bad-version/submissions/1339024761/

using System;
					
public class Program
{
	
	public static void Main()
	{
		Console.WriteLine("My Binary Search");
		int[] myArray = new int[100];
		int target = 42;
		
		for(var i = 0; i < myArray.Length; i++){
			myArray[i] = i;
		}
		
		int index = BinarySearch(myArray, target);
		
		if(index > -1){
			Console.WriteLine("Target {0} found at index {1}", target, index);
		}
		else{
			Console.WriteLine("target not found");
		}
		
	}
	
	private static int BinarySearch(int[] array, int target){
		int result = -1;
		
		int low = 0;
		int high = array.Length - 1;
		while(low <= high){
	
			int middle = low + (high - low) / 2;
			Console.WriteLine("middle: {0}", middle);
			if(array[middle] == target){
				result = middle;
				break;
			}
			else if(array[middle] < target){
				low = middle + 1;
			}
			else if(array[middle] > target){
				high = middle - 1;
			}
		}
		
		return result;
	}
	
	
}
