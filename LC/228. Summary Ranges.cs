public class Solution {
    public IList<string> SummaryRanges(int[] nums) {

        // What do I know?
        // There's 1 param, whithc is an array of integers and it's SORTED AND UNIQUE
        // Range is a set of integers where a,b are inclusive
        // Array can have ZERO elements, up to 20. 0 <= nums.length <= 20
        // Integers in the array can be negative or positive. -231 <= nums[i] <= 231 - 1
        // Array is sorted ascenting

        // How can I approach this?
        // Iterating through nums just once will give me a time complexity of O(n)
        // I would know if an integer is in the range if it is equal to the previus number plus 1. current = previous + 1
        // If current != previous + 1, start a new range
        // Is there a data structure or algorithm that could make my life easier? 
        //  I think we just need a variable to store previous integer (if anything)
        // Does SORTED AND UNIQUE give a clue that I should use a specific algorithm? Maybe binary search? But this won't tell me
        // if all integers are part of the range

        // Test cases
        // []
        // [1]
        // [0,1]
        // [0,1,2]
        // [0,1,2,4]
        // [0,2,4,6,8] 
        
        // Let's go!

        // After refactoring
        IList<string> resultList = new List<string>();
        if(nums.Length == 0) return resultList;
        
        int start = nums[0];
        for (int i = 1; i <= nums.Length; i++)
        {
            // Either end of array or gap in range
            if (i == nums.Length || nums[i] != nums[i - 1] + 1)
            {
                if (start == nums[i - 1])
                    resultList.Add(start.ToString());
                else
                    resultList.Add($"{start}->{nums[i - 1]}");

                if (i < nums.Length)
                    start = nums[i];
            }
        }

        return resultList;
 
        // Before refactoring
        // IList<string> resultList = new List<string>();
        // if(nums.Length == 0) return resultList;
        
        // int prevNumber = 0;
        // int? currentRange = null;
        // for(int i = 0; i < nums.Length; i++){

        //     if(currentRange == null){
        //         currentRange = nums[i];
        //     }
        //     else if(nums[i] == prevNumber + 1){
        //         prevNumber = nums[i];
        //         continue;
        //     }
        //     else{
        //         // TODO: refactor
        //         if(currentRange == prevNumber){
        //             resultList.Add(currentRange.ToString());
        //         }
        //         else{
        //             resultList.Add(currentRange.ToString() + $"->{prevNumber}");
        //         }
        //         currentRange = nums[i];

        //     }
        //     prevNumber = nums[i];
        // }

        // // TODO: May need to refactor this
        // if(currentRange != null && currentRange == prevNumber){
        //     resultList.Add(currentRange.ToString());
        // }
        // else{
        //     resultList.Add(currentRange.ToString() + $"->{prevNumber}");
        // }

        // return resultList;
        
    }
}