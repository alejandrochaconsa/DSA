/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        
        // What do I know
        // A Node is passed as param
        // Need to return the head Node of the new copy 
        // I can access properties of the Node as shown above
        // I must ensure the current node points to the correct node as well as random
        // The new copy should not point to any of the nodes pass in the param
        // Random only points to null or to Nodes previously created
        
        // Constraints:
        // 0 <= n <= 1000
        // -104 <= Node.val <= 104
        // Node.random is null

        // Notes to selt: After attempting to go the recursion route, I could not continue because I needed a way to reference
        // nodes to create the random copy
        // Solution 2 handles this although the space complexity is not the greatest.
        // Time complexity O(n)
        // Space complexity O(n)
        
        // solution 1:
        // Node result = HelperCopyNextList(head);
        // return result;
        
        // Solution 2:
        if (head == null) return null;

        Dictionary<Node,Node> nodeMap = new Dictionary<Node,Node>();

        Node currentNode = head;
        while(currentNode != null){
            Console.WriteLine(currentNode.val);
            nodeMap[currentNode] = new Node(currentNode.val);
            currentNode = currentNode.next;
        }

        currentNode = head;
        while(currentNode != null){
            // next
            if(currentNode.next != null){
                nodeMap[currentNode].next = nodeMap[currentNode.next];
            }
            else{
                nodeMap[currentNode].next = null;
            }
            // random
            if(currentNode.random != null){
                nodeMap[currentNode].random = nodeMap[currentNode.random];
            }
            else{
                nodeMap[currentNode].random = null;
            }
            currentNode = currentNode.next;
        }

        return nodeMap[head];
    }
    
    // private Node HelperCopyNextList(Node head, Node prevNode = null){
 
    //     // Base case
    //     if(head == null) return head;
        
    //     Node headCopy = new Node(head.val);// creates new node
    //     if(prevNode != null){
    //         prevNode.next = headCopy;
    //     }// point prevNode.next to new node created
        
    //     // Console.WriteLine(headCopy.val);
    //     HelperCopyNextList(head.next, headCopy);
        
    //     return headCopy;
    // }
    
}