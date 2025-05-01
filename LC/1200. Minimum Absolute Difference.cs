public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        // What do I know?
        // arr is not order
        // funct needs to return a list of list in asc order
        // values can be negative
        // all values are distinct

        // Approach:
        // Need to find pair that has the minimum absolute diff
        // Then find all the pairs that match the number found above
        // Can I sort the array? does it matter?
        // If I sort, I know that the minimum diff will be the subtraction of current number - nextNumber

        // Solution 1: 
        // Time complexity: O(n logn) + O(n) + O(n) => n logn
        // Space complexity: O(n)
        // Notes to self: Alejo, you got it to work in 15 mins, now you just need to enhance it

        IList<IList<int>> result = new List<IList<int>>();
        int minimumAbsDifference = int.MaxValue;
        // Validation
        if(arr.Length < 2) return result;

        Array.Sort(arr);
        // Console.WriteLine(String.Join(",", arr));

        for(int i =0; i < arr.Length - 1; i++){
            int currentMinimumAbsDifference = arr[i+1] - arr[i];
            minimumAbsDifference = Math.Min(minimumAbsDifference, currentMinimumAbsDifference);
        }

        for(int i =0; i < arr.Length - 1; i++){
            int currentMinimumAbsDifference = arr[i+1] - arr[i];
            if(currentMinimumAbsDifference == minimumAbsDifference){
                // Add pair to list
                List<int> listOfPairs = new List<int> {arr[i], arr[i+1]};
                result.Add(listOfPairs);
            }
        }

        return result;
    }
}