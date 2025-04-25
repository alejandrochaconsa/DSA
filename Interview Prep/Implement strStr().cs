public class Solution {
    public int StrStr(string haystack, string needle) {
        
        if(needle == "") return 0;
                
        if(needle.Length > haystack.Length
           ||(haystack.Length < 1 || haystack.Length > Math.Pow(10,4))) 
            return -1;
              
        for(int indexA = 0; indexA < haystack.Length - needle.Length +1; indexA++){
            Console.WriteLine(haystack[indexA]);
            if(needle == haystack.Substring(indexA,needle.Count())){
                return indexA;
            }       
        }
        
        return -1;
    }
        
        

        
//         int result = -1;
//         var haystackToLower = haystack.ToLower();
//         var needleToLower = needle.ToLower();
//         var needleIndex = 0;

//         try{
//             // Validate params
//             if((haystack.Length < 1 || haystack.Length > 10000) || (needle.Length < 1 || needle.Length > 10000)){
//                 // Console.WriteLine("Invalid parameters");
//                 return result;
//             }
//             var match = false;
    
//             for(var i = 0; i < haystackToLower.Length;  i++){
//                 Console.WriteLine("is haystackToLower[i]: " + haystackToLower[i] + " = needleToLower[needleIndex]: " + needleToLower[needleIndex]);

//                 if(haystackToLower[i] == needleToLower[needleIndex]){ 
//                     needleIndex++;
//                     if(needleIndex == needleToLower.Length){
//                             match = true;
//                     }
//                     else{
//                         for(var j = i + 1; j < needleToLower.Length + i; j++){
//                             if(haystackToLower[j] != needleToLower[needleIndex]){
//                                 needleIndex = 0;
//                                 break;
//                             }
//                             needleIndex++;
//                             if(needleIndex == needleToLower.Length){
//                                 match = true;
//                             }
//                         }
//                     }
                    
//                 }
//                 // If match is alrady found break the loop, otherwise continue iterating
//                 if(match){
//                     result = i;
//                     break;
//                 }
//             }
//         }
//         catch(Exception ex){
//             Console.WriteLine("Error: " + ex + "Inner Exception: " + ex.InnerException);
//         }

//         return result;
        
//     }
}