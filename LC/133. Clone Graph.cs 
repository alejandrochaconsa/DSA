/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {

        // What do I know?
        // Param is a node, has a value int and a List that represents the neighbors
        // the graph is undirected, meaning, bidirectional (be careful with cycles)
        // Must return a deep copy of the original
        // Values are in same order as the index (1-indexed)
        
        // Approach: (this was my initial approach wich was headed in the right direction, but was not quite there. See steps in comments below for actual approach that works)
        // [] Validate as node can be empty
        // Do I need to convert this into a dictionary to iterate through? Nope, I think the node represent the same as the kvp in the dictionary
        // 1. Create a new node clone to return
        // 2. Pass in the initial Node to a function
        // 3. that function is going to iterate through all nodes in its' list that are neighbors and each neigbor is going to be pass to the smae recursively
        // 4. Make sure that you keep track of the nodes that have been already VISITED/CLONED
        // 5. Return new node created on 1

        // Notes to self:
        // Alejo, you had a good intuition, on how to approach the problem, however, you weren't able to solve the exercise on time. After going through a tutorial, 
        // you have a better understanding of what needs to be done, so this is what you'll be doing now

        // Time complexity: O(V + E) vertex,edge => O(n) where n is the number of nodes, and each node and neighbors are only visited once
        // Space complexity: O(n) where n is the number of nodes being cloned

        if(node == null) return null;
        Dictionary<Node, Node> clonedMap = new();
        return  CloneDFS(node, clonedMap);
        
    }

    private Node CloneDFS(Node node, Dictionary<Node, Node> clonedMap){
        // 1. If node was already cloned, return the clone
        if(clonedMap.ContainsKey(node))
        {   
            return clonedMap[node];
        }

        // 2. Clone the current node and add it to the map
        Node clone = new(node.val);
        clonedMap.Add(node, clone);

        // 3. Iterate through the list of nodes to:
        //      a. Create clone of themselves
        //      b. Add these clones to the list of nodes for the clone node
        foreach(Node neighbor in node.neighbors){
            var clonedNeighbor = CloneDFS(neighbor, clonedMap);
            clone.neighbors.Add(clonedNeighbor);
            // Console.WriteLine($"clone val: {clone.val} clonedNeighbor: {clonedNeighbor.val}");
        } 

        return clone;
    }
}