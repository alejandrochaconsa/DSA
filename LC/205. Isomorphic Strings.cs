public class Solution {
    public bool IsIsomorphic(string s, string t) {
        // What do I know?
        // There are 2 string params s and t
        // The function must return a bool true if the 2 strings in the params ar isomorphic
        // NO TWO CHARACTERS may map to the same character, but a character may map to itself
        // Constraints:
        // 1 <= s.length <= 5 * 10,000 there will always be at least 1 character
        // t.length == s.length, the lenght of both params is always the same
        // s and t consist of any valid ascii character.
        // They can be mapped in the same order only, example: "aab" "dcc"=false, but "aab" "ccd"=true

        // What can I do? 
        // Iterate through each character and start mapping
        // Keep track of which character from s is mapped to which character in t
        // if not mapped yet, keep going
        // if mapped already and attempting to map to the same character, continue
        // if mapped already and attempting to map to the different character, return false
        // How can I keep track of the mappings? Dictionary<Char,Char>
        // Example: "aab" "ccd" true
        // Dictionary:
        // a:c
        // b:d
        // Example: "aab" "cdf" false
        // Dictionary:
        // a:c
        // a is already mapped so it cannot be mapped to d, therefore return false

        // Other Examples
        // "a" "a"     true
        // "a" "b"     true
        // "ab" "cd"   true
        // "aab" "ccd" true
        // "aab" "cdf" false
        // "aba" "cdc" true
        
        // Improvements: Add a try catch for exceptions, and logging purposes

        // Solution 1: Runtime is not as efficient as in Solution 2 below, but Time complexity is still O(n) at best or O(n^2) at worst because of 
        // this lookup myDictionary.ContainsValue(currentT)
       
        // if(s.Length != t.Length){
        //     return false;
        // }  
        // Dictionary<Char,Char> myDictionary = new Dictionary<Char,Char>();

        // for(int i = 0; i < s.Length; i++){

        //     Char currentS = s[i];
        //     Char currentT = t[i];

        //     Console.WriteLine(currentS);
        //     if(!myDictionary.ContainsKey(currentS)){
        //         if(myDictionary.ContainsValue(currentT)){
        //             return false;
        //         }
        //         myDictionary.Add(currentS,currentT);
        //     }
        //     if(myDictionary[currentS] != currentT){
        //         return false;
        //     }
        // }

        // return true;


        // Solution 2: Using 2 dictionaries, the Space complexity is still the same as in solution 1 if we remove the constant values, but Runtime is more efficient
        if(s.Length != t.Length) return false;

        Dictionary<Char,Char> dictionaryST = new Dictionary<Char,Char>();
        Dictionary<Char,Char> dictionaryTS = new Dictionary<Char,Char>();

        for(int i=0; i < s.Length; i++){
            
            if(!dictionaryST.ContainsKey(s[i])){
                dictionaryST.Add(s[i],t[i]);
            }
            else if(dictionaryST[s[i]] != t[i]){
                return false;
            }
            if(!dictionaryTS.ContainsKey(t[i])){
                dictionaryTS.Add(t[i], s[i]);
            }
            else if(dictionaryTS[t[i]] != s[i]){
                return false;
            }
        }

        return true;

    }     
}