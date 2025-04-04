// Bubble Sort

// Is a sorting algorithm in which adjacent elements in an array are compared and if not in order, the elements are swtiched. This is done to all elements until the whole
// array is in order.

// Runtime Complexity: O(n^2) - the larger the dataset, the more ineficient this algorithm will be.
// Use for a small dataset... NOT for a big dataset

//Source: https://www.youtube.com/watch?v=Dv4qLJcxus8
//Fiddle: https://dotnetfiddle.net/jxmKt9

using System;
					
public class Program
{
	public static void Main()
	{
		int[] array = {2,3,4,6,5,7,9,8,1};
		//int[] array = {9,3,1};
		Console.WriteLine("Array before using bubble sort:");
		
		foreach(int element in array){
			Console.Write(element);
		};
		
		BubbleSort(array);
		
		Console.WriteLine("\n\nArray after using bubble sort:");
		
		foreach(int element in array){
			Console.Write(element);
		};
		
	}
	
	public static void BubbleSort(int[] array){
		
		int iterationCount = 0;
		for(int j= 1; j < array.Length; j++){
			iterationCount++;
			for(int i = 0; i < array.Length - j; i++){
				var tempElement = array[i];

				if(array[i] > array[i+1]){
					array[i] = array[i+1];
					array[i+1] = tempElement;
				}
			}
		}
		
		Console.WriteLine("Iteration count: {0}",iterationCount);
		
	}
}