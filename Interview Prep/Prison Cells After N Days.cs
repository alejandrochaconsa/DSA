public class Solution {
    public int[] PrisonAfterNDays(int[] cells, int n) {
        // What do I know?
        // 2 params cells and n which is number of days starting at 0
        // If the adjacent cells are both occupied or vacant then the middle cell becomes occupied
        // else becomes vacant
        // The first and last cells don't have any adjacent cells
        // Return state of prison after n days
        // Constraints:
        //  cells.length == 8 We have a fixed length of 8 cells
        //  cells[i] is either 0 or 1. Values can only be 0/1
        //  1 <= n <= 10^9 or 1,000,000,000 up to a million days can pass
        
        // What can I do?
        // Can I use an algorithm?
        // Can I use a particular DS?
        // Iterate through the cells, it seems I'm gonna have to do a nested loop 
        // which could have a time complexity O(n^2) which may not be acceptable 
        // when n = 10^9
        // There must be a pattern I can use to avoid running logic when it is detected
        // I'll approach using the nested for loops and then refactor from there
        //  [x] if first cell or last cell and it's 1, it becomes 0 (empty)
        //  if leftCell is 1 and rightCell is 1 then currentCell 1
        //  if leftCell is 0 and rightCell is 0 then currentCell 1
        // I'm worried about the n size being 1,000,000,000, algorithm has to be efficient
        
        // As I suspected, a TLE was thrown with the nested loop approach
        // I must revisit 
        
        // Validations
        if(cells.Length > 8 || n < 1) return cells;
        
        int[] current = new int[cells.Length];
        int[] result = new int[cells.Length];
        
        Array.Copy(cells, result, cells.Length);
        
        //Console.WriteLine(string.Join(",", result));
        
        for(int i = 1; i <= n; i++){
            
            Array.Copy(result, current, cells.Length);
            // Console.WriteLine(string.Join(",", result));
            
            for(int j = 0; j < current.Length; j++){
                // first and last cell
                if(j == 0 && current[j] == 1 
                  || j == current.Length - 1 && current[j] == 1){
                    current[j] = 0; 
                    continue;
                }
                else if(j == 0 || j == current.Length - 1){
                    continue;
                }
                
                // Console.WriteLine($"j: {j}");
                
                int leftCell = result[j-1];
                int rightCell = result[j+1];
                
                // Console.WriteLine($"index:{j}. leftCell:{leftCell}. currentCell: [{current[j]}]. right:{rightCell}");
                
                if((leftCell == 1 && rightCell == 1)
                  ||(leftCell == 0 && rightCell == 0)){
                    // Console.WriteLine($"Making cell 1 at index {j}");
                    current[j] = 1;
                }
                else{
                    current[j] = 0;  
                    // Console.WriteLine($"Making cell 0 at index {j}");
                    
                }
            }
            Array.Copy(current, result, cells.Length);
            // Console.WriteLine(string.Join(",", result));
            
        }
        
        return result;
    }
}