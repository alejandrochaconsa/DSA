//using System;

public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        
        // What do I know?
        // Array has at minimum 2 elements
        // There's always at least 1 solution
        // I need to return the indexes of 2 NUMBERS that add up to target, IN ANY ORDER
        // Values in the array can be negative
        // Value of target can be negative
        // I cannot use the same element TWICE
        // List is not ordered
        // By this hit, I can tell there's a nested for loop approach:
        //  Can you come up with an algorithm that is less than O(n2) time complexity?
        
        
        // what can I do?
        // Can I order the list? does it make a difference?
        // I could prob:
        //  Order the list
        //  Use nested for loop 
        //  then maybe a data structure to simplify, by the hint, a dictionary
        
        // Solution 1:
//         Array.Sort(nums);
//         // Console.WriteLine(string.Join(",", nums));
//         for(int i = 0; i < nums.Length; i++){
//             for(int j = i+1; j < nums.Length; j++){
//                 int sum = nums[i] + nums[j];
                
//                 if(sum == target){
//                     result[0] = i;
//                     result[1] = j;
//                 }
//                 if(sum < target){
//                     continue;
//                 }
//                 break;
//             }
            
//         }
        
        // Solution 2 (More efficient): 
        int[] result = new int[2];
        try{
            // Validation
            if(nums.Length < 2) throw new Exception("Invalid param nums");

            Dictionary<int,int> dict = new Dictionary<int,int>();
            for(int i=0; i < nums.Length; i++){
                int numLookingFor = target - nums[i];

                if(dict.ContainsKey(numLookingFor)){
                    result[0] = dict[numLookingFor];
                    result[1] = i;
                    break;
                }
                if(!dict.ContainsKey(nums[i])){
                    dict.Add(nums[i], i); 
                }
            }
            
        }catch(Exception ex){
            Console.WriteLine($"Exception: {ex}. 
                              InnerException: {ex.InnerException}. StackTrace: {ex.StackTrace}");
        }
        
        return result;

    }
}