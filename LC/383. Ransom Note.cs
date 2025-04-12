public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        // What do I know?
        // There are 2 strings being passed as params
        // We must return a bool based on weather we can construct ransomNote out of magazine param, without REUSING characters
        // Both params contain letters in the alphabet so only 26 characters available (no spaces)

        // What can I do?
        // Can I use a data structure? Prob a Dictionary for the chars in magazine and then iterate through ransomNote and subtract amount from dictionary every time
        // a char matches. If there are no matches or we ran out of an existent char then return false. (Needs 2 iteration, one for the dictionary and one for the ransomNote)
        // Can I do it without a data structure? Maybe, by using magazine.IndexOf and then removing that Char At the given index if it exists of course. (Needs 1 iteration)

        // Solution 1
        // Notes to self: Alejo, after submission, the answer was accepted, but Runtime was 19ms, it seems there's a faster way to do this, IndexOf may be your bottle neck
        // Time Complexity: O(n) where n is the amount of characters in ransomNote
        // Space Complexity: O(1) constant because we're only storing the index of 1 character at the time.
        // foreach(Char character in ransomNote){
        //     // Console.WriteLine(character);
        //     int indexOfChar = magazine.IndexOf(character);

        //     if(indexOfChar == -1){
        //         return false;
        //     }
        //     magazine = magazine.Remove(indexOfChar,1);
        //     // Console.WriteLine(magazine);
        // }

        // return true;

        // Solution 2
        // Time Complexity: O(n) Linear, where n is the size of ransomNote
        // Space Complexity: O(m) Linear, where m is the size of magazine
        // Notes to self: Alejo, although we sacrifice on space, the performance as a lot better on the 2nd solution using the dictionary
        // by cutting runtime down to 8ms (more than half)
        Dictionary<Char,int> myDictionary = new Dictionary<Char,int>();
        foreach(Char characterInMagazine in magazine){
            
            if(myDictionary.ContainsKey(characterInMagazine)){
                myDictionary[characterInMagazine]++;
                continue;
            }
            myDictionary.Add(characterInMagazine, 1);
        }

        foreach(Char characterInRansomNote in ransomNote){
            if(myDictionary.ContainsKey(characterInRansomNote) && myDictionary[characterInRansomNote] > 0){
                myDictionary[characterInRansomNote]--;
            }
            else{
                return false;
            }
        }

        return true;
    }
}