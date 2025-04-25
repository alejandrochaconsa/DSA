public class Solution {
    public int MaxArea(int[] height) {
        
        // What do I know?
        // Param is an array with ints that represent height of the walls
        // Function must return the max amount of water it can contain between walls and along x-axis
        
        // Constraints:
        // n == height.length 
        // 2 <= n <= 100000 (array must contain at least 2 colums)
        // 0 <= height[i] <= 10000 (Columns can be in this range)
        
        // Approach:
        // I could potentially use brute force, but we may run into a TLE
        // Seems like I can use a 2 pointer approach
        // Find the column with the highest numbers
        // that are further apart
        // Then use the height of the shortest column between the 2, to find area by nultiplying times
        // rightColumn index - leftColumn index

        if(height.Length < 2) return 0;
        
        // int leftColumnIndex = 0;
        int result = 0;
        int pointerA = 0;
        int pointerB = height.Length - 1;
        
        while(pointerA < pointerB){
            
            int area = (height[pointerA] < height[pointerB]) ? 
                height[pointerA] * (pointerB - pointerA) :
                height[pointerB] * (pointerB - pointerA);
            
            result = Math.Max(result, area);
            
            if(height[pointerA] > height[pointerB]){
                pointerB = pointerB - 1;
            }
            else{
                pointerA = pointerA + 1;
            }
            
        }
        
        return result;
        
        // What do I know:
        // There are at least 2 vertical lines passed
        // The height of the lines can be 0 up to 10^4
        // n = height.Length

        // Alejo: you can use a nested for loop, but the time complexity would not be as good as each for loop
        // has a time complexity of O(n), but since is nested then it would be O(n^2) quadratic time.
        // Let's try it anyways
        // As suspected, after submission, one of the test cases exceeded the time limit

        //***** Solution 1: Using nested for loops

        // int result = 0;
        // for(int i = 0; i < height.Length - 1; i++){
        //     if(height[i] == 0){
        //         continue;
        //     }

        //     for(int j = i + 1; j < height.Length; j++){
        //         // the Area is calculated by how far apart the vertical lines are and their height
        //         if(height[j] == 0){
        //             continue;
        //         }

        //         if(height[i] < height[j]){
        //             result = Math.Max(result, height[i] * (j - i));
        //         }
        //         else{
        //             result = Math.Max(result, height[j] * (j - i));
        //         }
                
        //     }
        // }

        // return result;

        //***** Solution 1 end
    }
}