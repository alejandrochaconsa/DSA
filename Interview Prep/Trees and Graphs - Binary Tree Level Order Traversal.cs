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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        // What do I know?
        // TreeNode is passed as param which is the root of the tree
        // Function must return a List that contains a list of integers
        // Each list will represent the the level order traversal of its nodes' values
        // It's a Binary tree
        // There could be 0 nodes up to 2000
        // Node values can be negative
        
        // Contraints:
        // The number of nodes in the tree is in the range [0, 2000].
        // -1000 <= Node.val <= 1000
        
        // What can I do?
        // Can I use an algo? possibly BFS to traverse the tree widely
        // BFS will use a Queue data structure
        // I need to keep track of the levels, when I go to a new level,
        // insert current level list to the return list and start making a new list
        
        IList<IList<int>> resultList = new List<IList<int>>();
        // Validations
        if(root == null) return resultList;
        
        Queue<TreeNode> myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(root);
        
        while(myQueue.Count > 0){
            int levelSize = myQueue.Count;
            List<int> levelList = new List<int>();
            
            for(int i = 0; i < levelSize; i++ ){
                TreeNode currentNode = myQueue.Dequeue();
                levelList.Add(currentNode.val);
                
                if(currentNode.left != null){
                    myQueue.Enqueue(currentNode.left);
                }
                if(currentNode.right != null){
                    myQueue.Enqueue(currentNode.right);
                }
            }
            resultList.Add(levelList);
            
        }
        
        return resultList;
    }
}