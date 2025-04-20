public class Solution {
    // Step 1: Add all roman to integer representation to a dictionary
    private static readonly Dictionary<Char,int> romanMap = new Dictionary<Char,int>{
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
    };
    
    public int RomanToInt(string s) {
        
        // Input: s = "MCMXCIV"
        // Output: 1994
        
        // Validation
        if(s.Length < 1 || s.Length > 15) return 0;
        
        int result = 0;
        
        // Step 2: Iterate through each of the Roman characters in the string
        for(int i = 0; i < s.Length; i++){
            
            // Step 3: Get the int values for the current and next character from the Dictionary
            int current = romanMap[s[i]];
            int next = 0;
            
            // Check to prevent index out of bounds
            if(i+1 < s.Length){
                next = romanMap[s[i+1]];
            }
            // Console.WriteLine(s[i]);
            
            // Step 4: If the representation of the current integer 
            // is greater or equal to the representation of the upcoming integer
            // then we add the current integer to the final result;
            if(current >= next){
                result += current;
            }
            // Else if current integer is less than the upcoming integer, we subtract from
            // the result
            else{
                result -= current;
            }
            
        }
        
        return result;
        
        // This solution I worked on a while back and although it solve the issue, you can see how much         // more complex it is. Alejo, you've come a long way.
        
//         var total = 0;
//         var currentInteger = 0;
//         Nullable<char> upcomingCharacter = null;
        
//         try{

//             var stringArray = s.ToArray();

//             // Validations
//             if(stringArray.Length < 1 || stringArray.Length > 15){
//                 Console.WriteLine("Parameter S length is less than 1 or greater than 15");
//                 return total;
//             }

//             for(var i= 0; i < stringArray.Length; i++){
//                 var currentCharacter = stringArray[i];

//                 if(i+1 < stringArray.Length){
//                     upcomingCharacter = stringArray[i+1];
//                 }
//                 else{
//                     upcomingCharacter = null;
//                 }

//                 if(currentCharacter == 'I' ||
//                 currentCharacter == 'V' ||
//                 currentCharacter == 'X' ||
//                 currentCharacter == 'L' ||
//                 currentCharacter == 'C' ||
//                 currentCharacter == 'D' ||
//                 currentCharacter == 'M'){
                
//                     // Convert roman to int value
//                     switch(currentCharacter){
//                         case 'I':
//                             currentInteger = 1;
//                             break;
//                         case 'V':
//                             currentInteger = 5;
//                             break;
//                         case 'X':
//                             currentInteger = 10;
//                             break;
//                         case 'L':
//                             currentInteger = 50;
//                             break;
//                         case 'C':
//                             currentInteger = 100;
//                             break;
//                         case 'D':
//                             currentInteger = 500;
//                             break;
//                         case 'M':
//                             currentInteger = 1000;
//                             break;
//                         default:
//                             currentInteger = 0;
//                             break;

//                     }
                    
//                     // Console.WriteLine("Total: " + total);
//                     // Console.WriteLine("currentChar: " + currentCharacter);
//                     // Console.WriteLine("upcomingChar: " + upcomingCharacter);

//                     //Make decision if add or subtract
//                     if((currentCharacter == 'I' && upcomingCharacter == 'V') || (currentCharacter == 'I' && upcomingCharacter == 'X')){
//                         total -= currentInteger;
//                         continue;
//                     }

//                     if((currentCharacter == 'X' && upcomingCharacter == 'L') || (currentCharacter == 'X' && upcomingCharacter == 'C')){
//                         total -= currentInteger;
//                         continue;
//                     }

//                     if((currentCharacter == 'C' && upcomingCharacter == 'D') || (currentCharacter == 'C' && upcomingCharacter == 'M')){
//                         total -= currentInteger;
//                         continue;
//                     }

//                     total += currentInteger;
//                 }
//                 else{
//                     Console.WriteLine($"Parameter S contains invalid Roman character(s). Current Character: [{0}]  ", currentCharacter);
//                     return total;
//                 }
//             }
//         }
//         catch(Exception ex){
//             Console.WriteLine("Error: " + ex);
//         }

//         return total;
        
    }
}