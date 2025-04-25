public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        // What do I know?
        // string is passed as param
        // param s can have English letters, digits and spaces
        // Function must return the length of the longest substring
        // []param s can be EMPTY, which in this case it should return 0
        
        
        // Waht can I do?
        // Can I use a data structure to help? Dictionary of HashSet?
        // Can I us 2 pointer?
        
        // Solution 2: best approach
        int result = 0;
        if(s.Length == 0) return result;
        
        int indexA = 0;
        int indexB = 0;
        HashSet<Char> myHash = new HashSet<Char>();
        
        while(indexB < s.Length){
            if(!myHash.Contains(s[indexB])){
              myHash.Add(s[indexB]);
              result = Math.Max(result, indexB - indexA + 1);
              indexB++;
            }
            else{
                myHash.Remove(s[indexA]);
                indexA++; 
            
            }
        }
        return result;
        
        // Solution 1:
//         int result = 0;
//         HashSet<Char> myHash = new HashSet<Char>();
        
//         for(int i = 0; i < s.Length; i++){
//             myHash.Add(s[i]);
//             for(int j = i+1; j < s.Length; j++){
//                 if(!myHash.Contains(s[j])){
//                     myHash.Add(s[j]);
//                     continue;
//                 }
//                 else if(myHash.Count() == 1){
//                     continue;
//                 }
//                 result = Math.Max(result, myHash.Count());
//                 myHash = new HashSet<Char>();
//                 break;
//             }
                
//         }
        
//         result = Math.Max(result, myHash.Count());
        
//         return result;

    }
}