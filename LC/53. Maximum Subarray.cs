public class Solution {

    // Notes to self: Alejo, your solution(Solution 1) below did ok, for a small array but once it grew you got a TLE error because the 
    // time complexity: O(n^2) since it grows exponentially for every level. 
    // There's a way to tackle this problem with an algorithm you didn't know about: Kadane’s Algorithm — Time Complexity: O(n)
    // After debugging using the code below, you understand what is doing, but never in a million years, you would have been able to come up with such algorithm
    // Maybe in year 1,000,001, keep pushing!

    // (Kadane’s Algorithm — Time Complexity: O(n))
    // public int MaxSubArray(int[] nums) {
    //     int currentMax = nums[0];
    //     int globalMax = nums[0];

    //     for (int i = 1; i < nums.Length; i++) {
    //         currentMax = Math.Max(nums[i], currentMax + nums[i]);
    //         globalMax = Math.Max(globalMax, currentMax);
    //     }

    //     return globalMax;
    // }

    // Solution 1:
    public int MaxSubArray(int[] nums) {
        // What do we know?
        // param is an array, it must have at least 1 element
        // Need to find a subarray that returns an int with the largest sum, it could be 1 element or it could be the entire array
        // Elements in the array can be both positive and negative
        // Contraints: 1 <= nums.length <= 100,000, -10,000 <= nums[i] <= 10,000
        // Based on the follow up, there's a O(n) solution, but divide and conquer approach make it sound like there could be binary search involved (we'll see)

        // Let's look at the test cases
        // We have [1] the case with the least amount of elements
        // We have [5,4,-1,7,8], where the entire array makes up the larges sum
        // We have [-2,1,-3,4,-1,2,1,-5,4], where a sub array makes up the largest sum

        // What can we do?
        // Can we order? No
        // We can solve this in a tree where each level = nums.Length - 1 until we reach 1
        //                                          [5,4,-1,7,8] (5)
        //                                      [5,4,-1,7]  [4,-1,7,8](4)
        //                                   [5,4,-1]   [4,-1,7]   [-1,7,8](3)     
        //                                 [5,4]    [4,-1]    [-1,7]     [7,8] (2)
        //                               [5]      [4]       [-1]      [7]      [8](1)                                       
        // The base case is when I reach a leaf node (1 element only)

        //         [2,1,4]     (3)
        //        [2,1] [1,4] (2)
        //       [2]  [1]  [4] (1)

        return HelperMaxSubArray(nums, nums.Length);
        // Console.WriteLine(nums.Sum());
       

    }

    private int HelperMaxSubArray(int[] nums, int level){

        if(level == 0){
            return Int32.MinValue;
        }

        int indexA = 0;

        int sum = Int32.MinValue;

        int[] subArray = new int[level];
        
        while(indexA + level <= nums.Length){

            Array.Copy(nums, indexA, subArray, 0, level);
            sum = Math.Max(sum, subArray.Sum());
            indexA++;
        }
 
        return Math.Max(sum, HelperMaxSubArray(nums, level - 1));
    }
}