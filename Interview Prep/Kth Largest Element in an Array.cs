public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // What do I know?
        // An array is passed as param and an int k
        // I must find the kth largest element in the array
        // Since it says largest, that means I should think of the array in descending order
        // Example:
        // nums = [3,2,1,5,6,4], k = 2
        // then [6,5,4,3,2,1] at index k = 2 the result would be 4
        // but they're asking to solve without sorting
        // [x] 1 <= k <= nums.length <= 10^5 There's always at leas 1 int in nums
        // -10^4 <= nums[i] <= 10^4 Values can be negative
        
        // What can I do?
        // Is there an algorithm I can use?
        // Is there a data structure I can use? Maybe a sorted dictionary, although the problem says
        // not sorting
        // Maybe I can use a PriorityQueue
                
        if(nums.Length == 0) return 0;
    
        PriorityQueue<int,int> myQueue = new();
        
        foreach(int integer in nums){
            
            myQueue.Enqueue(integer,integer);
            
        }
        
        int count = myQueue.Count;
        for(int i = 0; i < count - k; i++){
            Console.WriteLine($"Dequeuing: {myQueue.Peek()}");
            myQueue.Dequeue();
        }
        
        return myQueue.Peek();
        
    }
}