// Sliding Window Pattern

// My definition: Use this whenever the problem is asking to find a subarray that is equivalent to something. 
// Tech definition: Sliding Window problems are problems in which a fixed or variable-size window is moved through a data structure, typically an array or string, to solve problems 
// efficiently based on continuous subsets of elements. This technique is used when we need to find subarrays or substrings according to a given set of conditions.

// Example problems:
// https://leetcode.com/problems/maximum-average-subarray-i/description/


public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        // Use Sliding window pattern

        double maxAverage = double.MinValue;
        int tempSum = 0;
        double tempAverage = 0.0;

        try{
            // Validate params
            if(nums.Count() < 0 || k == 0){
                return maxAverage;
            }
            else if(k == 1)
            {
                Array.Sort(nums);
                return nums[nums.Length - 1];
            }
            else{

                // Starting point here
                for(var i = 0; i < k; i++){
                    tempSum += nums[i];
                }
                tempAverage += (double)tempSum / k;
                maxAverage = Math.Max(maxAverage, tempAverage);
                //

                // Moving window here
                for( int i = 1; i < nums.Length - k + 1; i++ ){
                    tempSum -= nums[i - 1];
                    tempSum += nums[i + k -1];
                    tempAverage =  (double)tempSum/k;
                    maxAverage = Math.Max(maxAverage, tempAverage);
                }
                //
            }
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }

        return maxAverage;
    }
}
