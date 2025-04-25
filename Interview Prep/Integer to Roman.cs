public class Solution {
    
    //Step 1: complete the Dictionary
    private static readonly Dictionary<int,string> romanMap = new Dictionary<int, string>{
        {1000, "M"},
        {900, "CM"},
        {500, "D"},
        {400, "CD"},
        {100, "C"},
        {90, "XC"},
        {50, "L"},
        {40, "XL"},
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"}        
    };
    
    public string IntToRoman(int num) {

        if(num < 1 || num > 3999) return "";
        
        string result = "";
        // Step 2: Iterate through the dictionary in descending order
        foreach(var kvp in romanMap){

            // Console.WriteLine($"Key: {kvp.Key} Value:{kvp.Value}");

            // Step 3: Divide the number by the current Key in the dictionary
            int divisionResult = num / kvp.Key;

            // Step 4: If division result is 0, we continue
            if(divisionResult == 0){
                continue;
            }
            //Step 5: If division result greater than 0 then we have to buil the string 
            else{
                // Step 6: Append the string Value that represents the current Key as many times as needed based on the result of the division
                while(divisionResult > 0){
                    // Console.WriteLine($"divisionResult:{divisionResult}");
                    result = result + kvp.Value; 
                    divisionResult--;
                }
                // Console.WriteLine(result);
            }
            // Step 7: Make num the remainder of the original number so you can continue to iterate and build the string
            num = num % (kvp.Key);
            // Console.WriteLine($"RestOfTheNumber: {num}");

        }
        
        return result;
    }
}