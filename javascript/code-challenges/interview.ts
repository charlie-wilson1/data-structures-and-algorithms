// suggestions

// spend less time on the pseudo code.
// Don't worry about naming.
// always try to collapse permutations if needed.

// find lengths of both linked lists.
// if both linked lists are equal in length, continue.
// if not, then find max and min of the two.

// create answer LL

// for loop with the max of the linked list lengths.
//
// If the value at i is equal to the min value of second list, perform below operation
// Add value at both linked lists together
// is value greater than or equal to 10? if yes, call helper function with value, else set the value of ans node to value.
// push both LLs forward.

// else set value of LL current to value at the max linked list
// push LL forward.

// HELPER FUNCTION
// set remainder to : value mod 10 
// set ans LL value to remainder
// increment value at position

function SolveBanana: ListNode (list1: ListNode, list2: ListNode) {
    let len1 = list1.len
    let len2 = list2.len

    let ansHeadNode: ListNode = new();
    let ansCurrent: ListNode = ansHeadNode;

    if (len1 !== len2) {
        let largerNode: obj  = new();
        if (len1 > len2) {
            largerNode = list1;
            var min = list2
            var max = list1;
        }
        else {
            largerNode = list2;
            var min = list1;
            var max = list2;
        }
        for (let i = max; i > min; i--) {
            ansCurrent.val = largerNode.val;
            ansCurrent
        }
    }

    for (let i = len1; i > 0; i--) {
        let ansVal = list1.val + list2.val;
        if (ansVal >= 10) {
            helper(ansVal);
        }
        else { ansCurrent.val = ansVal; }
            ansCurrent = ansCurrent.next;
            list1 = list1.next;
            list1 = list2.next;
    }
}