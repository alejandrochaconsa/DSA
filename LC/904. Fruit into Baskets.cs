public class Solution {
    public int TotalFruit(int[] fruits) {
        
        // Notes:
        // Given an integer array fruits
        // Each element in array is a tree
        // Collect as much fruit as possible
        // Rules:   
        //  I have 2 baskets and each basket can only hold 1 type of fruit
        //  Start form any tree
        //  As you move right, count the trees and STOP once you reach a tree you cannot fit into basket 
        // Return maximum number of fruits (better said, the maximum number of trees you can pick from)
        
        // Approach:
        // My initial approach of using a Dictionary and a sliding window was correct.
        // Dictionary will kee track of the type of fruit I'm picking
        // Create a left and right pointer
        // move the right pointer and add the type ofr fruit and qty of tree to the Dictionary
        // If dictionary is greater than 2, the rule "You only have two baskets, and each basket can only hold a single type of fruit." is being violated
        // Get the max count
        // Move the left towards the right until the dictionary is back to 2 and continue

        // Notes to self: Alejo, you had a good intuition at the beginning, but then diviated and went a dirrefent route.
        // Practice sliding window patterns, cause it's been a while since you last practice them. After rewriting the exercise with some guidance,
        // you now understand what is going on. You're 1% better today!

        Dictionary<int, int> fruitMap = new();
        int result = 0;
        int left = 0;

        for(int right = 0; right < fruits.Length; right++){
            int currentFruit = fruits[right];

            if(!fruitMap.ContainsKey(currentFruit)){
                fruitMap.Add(currentFruit, 1);
            }
            else{
                fruitMap[currentFruit]++;
            }

            while(fruitMap.Count > 2){ 
                int leftFruit = fruits[left];

                if(fruitMap.ContainsKey(leftFruit) && fruitMap[leftFruit] > 0){
                    fruitMap[leftFruit]--;
                    left++;
                }
                if(fruitMap[leftFruit] == 0){
                    fruitMap.Remove(leftFruit);
                }

            }

            result = Math.Max(result, right - left + 1);
        }

        return result;

    }
}