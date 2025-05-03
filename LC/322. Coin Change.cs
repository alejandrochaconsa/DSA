public class Solution {
    public int CoinChange(int[] coins, int amount) {

        // What do I know?
        // I have infinite amount of coins
        // Function must return the fewest number of coins
        // Amount can be 0
        // Array of coins has at least 1 coint (element)

        // Approach:
        // Order the coins 
        // Iterate through coins in decreasing order
        // Keep subtracting from the amount until reach 0
        // if amounts becomes negative, you went too far, iterate through next coin 
        // if amount is not 0 by the end return -1, else return result
        
        // Notes to self: Alejo, greedy approach did not work, because combination can bemade out of different coin combinations
        // You got the dynamic programming approach working in about 40 mins, but you should revisit and debug to have a better understanding
        // int result = 0;
        // int amountCopy = amount;
        // if(amount == 0) return 0;
        // Array.Sort(coins);

        // Solution 1: Greedy approach
        // for(int i = coins.Length - 1; i >= 0; i--){
        //     while(amountCopy - coins[i] >= 0){
        //         amountCopy -= coins[i];
        //         result++;     
        //     }
        // }
        // return (amountCopy == 0) ? result : -1;
        Dictionary<int, int> memo  = new Dictionary<int,int>();
        int result = HelperCoinChange(coins, amount, memo);
        return (result >= (int)Math.Pow(10,5)) ? -1 : result;
        
    }

    // Solution 2: Dynamic promgramming and memo top down
    private int HelperCoinChange(int[] coins, int amount, Dictionary<int, int> memo){
        
        int result = int.MaxValue;
        
        // Base case
        if(memo.ContainsKey(amount)){
            return memo[amount];
        }

        if(amount == 0){
            return 0;
        }
        
        if(amount < 0){
            return (int)Math.Pow(10,5);
        }

        for(int i = 0; i < coins.Length; i++){
            int totalCoins = 1 + HelperCoinChange(coins, amount - coins[i], memo);
            result = Math.Min(result, totalCoins);
        }

        memo.Add(amount, result);
        return result;
    }
}