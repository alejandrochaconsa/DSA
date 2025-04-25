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
    public int CountNodes(TreeNode root) {
        // what do I know?
        // TreeNode is the param, the object has different properies I can access as shown above.
        // I must return an integer with the amount of nodes in the tree.
        // Node value range can be 0 <= Node.val <= 5 * 104, but this doesn't matter much as we don't care about their value.
        // [x] There could be ZERO (0) nodes, so make sure to acount for this.
        // [x] O(n) time complexity.

        // Approach:
        // We can use DFS or BFS through traverse the whole tree
        // Since we need to traverse all of the nodes it doesn't make a difference what algorithm we use
        // Set a counter to return at the end
        // We can use recursion or for loop

        // Notes to self:
        // Time complexity: O(n) 
        // Space Complexity: O(n) using a stack, that at most could have the n elements in the tree
        int counter = 0;

        try{
            // Param validation 
            if(root == null) return counter;

            Stack<TreeNode> myStack = new Stack<TreeNode>();
            myStack.Push(root);

            while(myStack.Count() > 0){
                // Console.WriteLine("Stack is not empty");
                TreeNode currentNode = myStack.Pop();
                counter++;

                if(currentNode.left != null){
                    myStack.Push(currentNode.left);
                }
                if(currentNode.right != null){
                    myStack.Push(currentNode.right);
                }
            }
        }
        catch(Exception ex){
            Console.WriteLine($"Exception: {ex}. InnerException: [{ex.InnerException}]. StackTrace: [{ex.StackTrace}]");
        }
        return counter;
    }
}