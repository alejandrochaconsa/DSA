/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    
    public ListNode ReverseList(ListNode head) {
        
        // What do I know
        // There could be 0 nodes up to 5000
        // Node values can be negative
        // The method must return the Linked list reversed
        // [ ] Account for scenario where there could be 0 nodes
        
        //Approach:
        // I could use recursion to iterate to the last node and then make them point
        // to the previous node
        // Do I need ant data structures? Seems like I don't need any for now
        
        if(head == null || head.next == null) {
            return head;
        }
        
        ListNode newHead = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        
        return newHead;
    }
        
}