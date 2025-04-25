public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {

        // What do I know?
        // Array of nums is passed as a param
        // Function must return a List of Lists with all the possible integer combinations that are equal to 0
        // Indexes cannot be equal
        // Numbers cannot be reused
        // The return list must not have duplicates
        // Order of the triplets doesn't matter
        // nums has at least 3 values in it

        // How can we approach this?
        // Obviously a 3 nested for loop would be the first approach that comes to mind, but time complexity would be O(n^3) 
        // which would be terribly slow
        // we'd also have to check to make sure we're not inserting into List multiple times
        // Another approach, would be to loop through the array, and use 2 pointer 

        IList<IList<int>> result = new List<IList<int>>();
        
        Array.Sort(nums);
        for(int i =0; i < nums.Length - 2; i++){
            // Console.WriteLine(string.Join(",",nums));
            if(i > 0 && nums[i] == nums[i-1]){
                continue;
            }
            int leftIndex = i+1;
            int rightIndex = nums.Length - 1;

            while(leftIndex < rightIndex){
               
                List<int> currentList = new List<int>();
                // Console.WriteLine($"i:[{i}] leftIndex:[{leftIndex}] rightIndex:[{rightIndex}]");
                int sum = nums[i] + nums[leftIndex] + nums[rightIndex];
                // Console.WriteLine($"sum: {sum}");

                if(sum == 0){
                    currentList.Add(nums[i]);
                    currentList.Add(nums[leftIndex]);
                    currentList.Add(nums[rightIndex]);

                    result.Add(currentList);
                    leftIndex++;
                    rightIndex--;

                    while(leftIndex < rightIndex && nums[leftIndex] == nums[leftIndex-1]){
                        leftIndex++;
                    }
                    while(leftIndex < rightIndex && nums[rightIndex] == nums[rightIndex+1]){
                        rightIndex--;
                    }

                }
                else if(sum < 0){
                    leftIndex++;
                }
                else{
                    rightIndex--;

                }

            }
        }
        return result;
        
    }
}