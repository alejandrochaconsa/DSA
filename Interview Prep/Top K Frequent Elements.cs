public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // What do I know?
        // 2 params , array nums and int k
        // nums must have at least 1 element
        // k is within range of the array
        // There is an answer guaranteed, and it's unique
        // Your algorithm's time complexity must be better than O(n log n), where n is the array's             // size. 
        // Answer can be returned in any order
        
        // What can I do?
        // can I use an algorithm?
        // What data structure can I use to simplify the logic? Maybe a Dictionary?
        // From follow up where time: O(n log n) seems like there's an approach to iterate and then to         // cut time in half 
       
        // Validation
        if(nums.Length == 0) return nums;
        
        Dictionary<int,int> myDictionary = new();
        PriorityQueue<int,int> myQ = new();
        int[] result = new int[k];
        
        foreach(int integer in nums){
            if(!myDictionary.ContainsKey(integer)){
                myDictionary.Add(integer, 1);
            }
            else{
                myDictionary[integer]++;
            }
        }
        
        foreach(var kvp in myDictionary){
            // Console.WriteLine($"key:{kvp.Key} value:{kvp.Value}");
            myQ.Enqueue(kvp.Key, kvp.Value);
        }
        
        while(myQ.Count > 0){
            int currentInteger = myQ.Dequeue();
            // Console.WriteLine(currentInteger + $"myQ.Count: {myQ.Count}" );
            if(myQ.Count < k){
                result[myQ.Count] = currentInteger;
                
            }
        }
        
        return result;
        
    }
}