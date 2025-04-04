// DFS Depth first search

// Depth First Search
// DFS = a search algorithm for traversing
// a tree or graph data structure.
// Usually used to traverse a tree vertically
// 1. Pick a route
// 2. Keep going until you reach a dead end, or a previously visited node
// 3. Backtrack to Last node that has unvisited adjacent neighbors

// Use if it is known that an answer will likely be found far into a tree
// .NET Fiddle: no fiddle

// leetCode: https://leetcode.com/problems/maximum-depth-of-n-ary-tree/post-solution/?submissionId=1339742539
public class Solution {
    public int MaxDepth(Node root) {
        var result = 0;
        if(root == null)
            return result;
        
        result = Dfs(root);

        return result;
        
    }

    public int Dfs(Node root){
        var maxDepth = Int32.MinValue;
        Stack<Node> myStackOfNodes = new Stack<Node>();
        Stack<int> depthStack = new Stack<int>();
        
        myStackOfNodes.Push(root);
        depthStack.Push(1);
        while(myStackOfNodes.Count() > 0){
            var currentNode = myStackOfNodes.Pop();
            var currentDepth = depthStack.Pop();
            maxDepth = Math.Max(maxDepth, currentDepth);

            foreach(var childNode in currentNode.children){
                myStackOfNodes.Push(childNode);
                depthStack.Push(currentDepth + 1);
            }
        }
        return maxDepth;
    }
}

// Answer 2 using recursion 
// leetCode: https://leetcode.com/problems/maximum-depth-of-n-ary-tree/post-solution/?submissionId=1339775868
public class Solution {
    public int MaxDepth(Node root) {
        var result = 0;
        if(root == null)
            return result;
        
        result = Dfs(root);

        return result;
        
    }

    public int Dfs(Node root){
        var maxDepth = Int32.MinValue;
        // Base case
        if(root.children.Count() == 0){
            return 1;
        }
        // Recursion
        foreach(var childNode in root.children){
            var currentDepth = 1 + Dfs(childNode);
            maxDepth = Math.Max(maxDepth, currentDepth);
        }

        return maxDepth;
    }
}