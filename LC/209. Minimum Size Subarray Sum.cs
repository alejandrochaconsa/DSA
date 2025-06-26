public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {

        // What do I know?
        // Function must return  minimal length of subarray where the sum is greater than or equal to target
        // If not foun, return 0
        // There's at least 1 element in nums array
        // Target and Value of arr elements > 0
        // SubArray

        // Approach
        // Base on the follow up I see there's time complexity solution of O(n), menaing I can do this in 1 or few iterations
        // Do I need to sort? Possibly, but that will give me a time complexity of O(nlogn) which is worst than O(n)
        // Notes to self: allejo, your intuitions were right about using a sliding window approach and 2 pointer
        // however, you took too long to execute and ran out of time. You should practice this one again


        int result = int.MaxValue;
        if(nums.Length < 1) return 0;

        int left = 0;
        int total = 0;

        for(int right = 0; right < nums.Length; right++){
            total += nums[right];

            while(total >= target){
                result = Math.Min(result, right - left + 1);
                total -= nums[left];
                left++;
            }
        }
        
        if(result == int.MaxValue){
            return 0;
        }
        return result;
        
    }
}