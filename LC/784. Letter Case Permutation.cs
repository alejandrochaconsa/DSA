public class Solution {
    public IList<string> LetterCasePermutation(string s) {

        // What do I know?
        // string s param 
        // return a list of strings of all possible combinations from s chars being lowercase or uppercase
        // s can be in the range of 1 to 12 inclusive
        // s can have digits upper and lowercase letters

        // Approach:
        // Iterate through each character
        // If letter, then we have 2 possibilities: Uppercase, Lowercase
        // If integer, append and keep iterating
        
        // Notes to self: Alejo, it's ok if time complexity is not optimal, in this scenario, it doubles for each character entry and that's ok
        // Focus on solving the problem first and then optimize it if possible 
        // Time complexity O(2^n)
        // Space complexity O(2^n), we're storing all possible permutations in a List

        IList<string> resultList = new List<string>(){""};

        if(s.Length < 1 || s.Length > 12) return resultList;

        for(int i = 0; i < s.Length; i++){
            Char currentChar = s[i];
            int count = resultList.Count;
            // Console.WriteLine(currentChar);

            if(Char.IsLetter(currentChar)){
                // Console.WriteLine("is Letter");
                for(int j = 0; j < count; j++){
                    string currentString = resultList[j];
                    resultList[j] = currentString + Char.ToLower(currentChar).ToString();
                    resultList.Add(currentString + Char.ToUpper(currentChar).ToString());

                    // Console.WriteLine(String.Join(",", resultList));
                }                
            }
            // Is number
            else{
                // Console.WriteLine("is Number");
                for(int k = 0; k < count; k++){
                    resultList[k] = resultList[k] + currentChar;
                    // Console.WriteLine("After adding number:" + resultList[k]);
                }
                // Console.WriteLine(String.Join(",", resultList));
            }

        }
        return resultList;
    }
}