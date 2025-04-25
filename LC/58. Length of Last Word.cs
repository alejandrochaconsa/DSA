public class Solution {
    public int LengthOfLastWord(string s) {
        
        // What do I know?
        // There's a string param that could have 26 char options plus spaces
        // There must be at least 1 word in s param
        // I must return an int with the count of characters in the last word
        // There can be several spaces concatenated 
        // Spaces can be at the beginning or end of the param
        // Constraints: 1 <= s.length <= 10000, s consists of only English letters and spaces ' '
        // The last word in s will contain only characters and no spaces in between

        // What can I do?
        // I need to find the last word in s efficiently
        // Should I us a data structure? maybe split string into array and get array[array.length - 1].Length (Maybe)
        // What about a Stack? I think is double the work because I would have to push 2 in it and then pop the last word out, could work but there's extra work
        // what if I use .LastIndexOf(" ") - 1? Could work for s that has space, but what if it doesn't?
        // If using a while/for, iterate backwards to reduce effort

        // Valid examples:
        // "a" = 1 (no space before or after last word)
        // " b " = 1 (1 space before, 1 space after)
        // " c de" = 2 (1 space before, no space after)
        // "f    jkl    " = 3 (1 space before, many space after)

        // Notes to self: Alejo, time complexity: O(n) and Space complexity: O(n) as is. Are there any improvements you can make?
        // What if I iterate through the string backwards, ignore spaces until you find a char, then continue to iterate until you find the next space or 
        // right before you go out of bounds.
        // Solution 1:
        // List<string> myList = new List<string>();
        // myList = s.Split().ToList();

        // Console.WriteLine($"myList: [{string.Join(",", myList)}]");

        // int count = myList.Count() - 1;
        // int lastWordCount = myList[count].Length;
        // while(lastWordCount == 0){
        //     count--;
        //     lastWordCount = myList[count].Length;
        // }

        // return lastWordCount;

        // Solution 2
        // Alejo: Solution 2 Time Complexity O(n) Space complexity = O(1)
        // The space complexity is way better on solution 2; therefore, this is the winner
        int count = s.Length - 1;
        int LastWordLength = 0;
        while(count >= 0){
            if(s[count] != ' '){
                LastWordLength++;
            }
            else if(LastWordLength > 0){
                break;
            }
            count--;
        }
        return LastWordLength;
    }
}