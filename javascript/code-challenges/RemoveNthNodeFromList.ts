/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} n
 * @return {ListNode}
 */
 var removeNthFromEnd = function: ListNode(head: ListNode, n: ListNode) {

    // METHOD ONE: TWO PASSES
    
    // set head to current
    // initialize maxCounter
    // while current not null, iterate through LL and increment counter.
    
    // set targetCounter to (max - n)
    // iterate through LL until reaching target (would be 3 in example)
    // initialize next var to current.next.next
    // set current.next to next var
    // return head
    
    // METHOD TWO: ONE PASS
    
    // init pointer1
    // init pointer2
    
    // set head to pointer2
    //iterate through list with first pointer while counting down with n + 1 (+1 because we want second pointer to lag behind 1 further in order to properly delete the pointer).
    //When n reaches 0, begin iterating the second pointer through the loop.
    
    // When first pointer reaches end, second pointer will be 1 before where the target var is.
    
    // set a "next" var to secondpointer.next.next 
    // set secondpointer.next var to "next"
    // return original head
};