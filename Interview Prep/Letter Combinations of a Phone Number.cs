public class Solution {
    
    private static readonly Dictionary<Char,string> charMap = new Dictionary<Char,string>{
        {'2',"abc"},  
        {'3',"def"},  
        {'4',"ghi"},  
        {'5',"jkl"},  
        {'6',"mno"},  
        {'7',"pqrs"},  
        {'8',"tuv"},  
        {'9',"wxyz"}
    };
    
    public IList<string> LetterCombinations(string digits) {
        // What do I know?
        // need to return a list of strings with all possible combinations
        // digits string can be empty
        // digits string could have at max 4 characters
        // digits string values can be in the range of ['2', '9'].
        // 7 and 9 have four characters, 1 does not have any.
        
        // What can I do?
        // I need to store the character representation for each of the digits (dictionary)
        // 2:"abc"
        // [x]need to account for when digits is empty
        
        // Notes to self: It took me 1hr 25 min to solve this problem
        // I must get faster at this if I want to do well in the interview
        // I got a bit confused during the recursion, but then I started over and it became clear
        // great progress overall!
        
        IList<string> resultList = new List<string>();
        string currentString = "";
        
        if(digits.Length == 0) return resultList;
        
        HelperLetterCombinations(digits, 0, resultList, currentString);
        
        return resultList;
        
    }
    
    private String HelperLetterCombinations(string digits, int index, IList<string> resultList, string currentString){
        
        // Console.WriteLine($"index: {index}");
        
        // Base case
        if(index >= digits.Length){
            // Console.WriteLine("Base case hit");
            resultList.Add(currentString);
            return currentString;
        }
        
        // Logic here
        for(int i = 0; i < charMap[digits[index]].Length; i++){
            // Console.WriteLine(charMap[digits[index]][i]);
            
            currentString += charMap[digits[index]][i]; 
            HelperLetterCombinations(digits, index + 1, resultList, currentString);
            currentString = currentString.Substring(0, currentString.Length - 1);
    
        }
        
        return currentString;
    }
}