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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        // What do I know?
        // Head of 2 Linked List as params
        // I must merged the 2 linked list into a sorted 1 and return the head of that list
        // The result linked list may have repeating values, it's ok as long as they stay in order
        // The number of nodes in each list could be [0, 50].
        // Params can be of different sizes as Example 3 shows
        // The value of the nodes can be NEGATIVE (-100 <= Node.val <= 100)
        // Both list1 and list2 are sorted in increasing order
        // [x] Validate when the nodes are ZERO (0)
        // I can only know current value and next value

        // Approach:
        // Iterate through until at least 1 of the lists is completed and there are no more elements to iterate through
        // As you iterate, if list1.next value is greater than the current value, then you should insert the smallest value

        // Additional test cases:
        // [2,3,4,5], [6,7,8,9]
        // [3,5,7], [1]

        // Notes to self: It took me 1hr 25min to resolve this exercise. It was good practices, but I gottat get faster/
        // Time Complexity: O(n+m) 
        // Space Complexity: O(n+m) 

        ListNode myNodeList = new ListNode();

        myNodeList = HelperMergeTwoLists(list1, list2, ref myNodeList);
        return myNodeList;
        
    }

    public ListNode HelperMergeTwoLists(ListNode list1, ListNode list2, ref ListNode myNodeList){

        // Base cases/Param Validations 
        if(list1 == null && list2 == null) return null;
        if(list1 == null){
            myNodeList = list2;
            return myNodeList;
        }
        if(list2 == null){
            myNodeList = list1;
            return myNodeList;
        }
    
        if(list1.val < list2.val){
            myNodeList = new ListNode(list1.val);
            HelperMergeTwoLists(list1.next, list2,ref myNodeList.next);
        }
        else if(list1.val > list2.val){
            myNodeList = new ListNode(list2.val);
            HelperMergeTwoLists(list1, list2.next, ref myNodeList.next);
        }
        else{
            myNodeList = new ListNode(list1.val);
            myNodeList.next = new ListNode(list2.val);
            HelperMergeTwoLists(list1.next, list2.next, ref myNodeList.next.next);
        }

        return myNodeList;
    }
}