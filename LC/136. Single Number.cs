public class Solution {
    public int SingleNumber(int[] nums) {
        // What do I know? 
        // Array is pass with duplicate values
        // Except one of them is not a duplicate
        // Method must find it and return it
        // Function time complexity must be O(n)
        // Space must be O(1)
        // Array is not in order
        // Array must have at least 1 value
        
        // Approach:
        // I cannot order, because it'd have a time complexity of O(nlogn)
        // No nested for loop as O(n^2)

        // Notes to self: Alejo you bombed this, as you did not resolve it as per the requirement o(n)
        // You have now learned about a new concept using bit manipulation using XOR(Exclusive Or)
        // Where:

        // Duplicates cancel out because:
        // a ^ a = 0

        // And the identity holds:
        // 0 ^ b = b
        // ✅ XOR Rules Recap:
        // Bit A   Bit B   A ^ B
        //  0       0       0
        //  0       1       1
        //  1       0       1
        //  1       1       0

        // Solution 2:
        int result = 0;

        foreach(int number in nums){
            Console.WriteLine(number);
            result = result ^ number;
        }
        
        return result;

        // Solution 1:
        // if(nums.Length < 3) return nums[0];
        
        // for(int leftIndex = 0; leftIndex < nums.Length - 1; leftIndex++){
        //     int rightIndex = leftIndex + 1;

        //     if(nums[leftIndex] == 4000){
        //         continue;
        //     }

        //     while(rightIndex < nums.Length && nums[leftIndex] != nums[rightIndex]){
        //         rightIndex++;
        //     }

        //     if(rightIndex < nums.Length && nums[leftIndex] == nums[rightIndex]){
        //         nums[rightIndex] = 4000;
        //     }
        //     else{
        //         return nums[leftIndex];
        //     }
        // }
        // return nums[nums.Length -1];

    }
}