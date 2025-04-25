/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        
        // What do I know? 
        // Binary tree smaller than root values are on the left and greater than root on right
        // There's at least 1 node in the tree [1, 10^4]
        // Nove values can be NEGATIVE -2^31 <= Node.val <= 2^31 - 1
        
        return HelperIsValidBST(root, long.MinValue, long.MaxValue);
        
    }
    
    private bool HelperIsValidBST(TreeNode node, long min, long max){
        
        // Validation
        if(node == null) return true;
        
        if (node.val <= min || node.val >= max) return false;
        
        return HelperIsValidBST(node.left, min, node.val) &&
               HelperIsValidBST(node.right, node.val, max);
    }
}