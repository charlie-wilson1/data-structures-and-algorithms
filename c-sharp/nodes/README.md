# Singly Linked List
- A singly linked list will always have both a Head and tail, which represent the start and end values subsequently.
- A singly linked list is made up of individual nodes. These nodes have a current value and a "next" value which points to the node directly forward of it.

## Challenge
Create a Linked list from scratch that can:
- Be printed out from beginning to end.
- Have values added to it.
- Determine whether or not a value exists inside of it.

## Approach & Efficiency
My approach for this project was to tackle the easier algorithm first, in this case print. We know that each Node's current value will need to be displayed therefore we utilize the Write method from the console and set the value our current to next until the current value is null (end of it.) <br>
After figuring this out, appending and including had similar processes - mainly assigning a pointer to the head node and performing the desired operation.
## API
``` cs
public class LinkedList() {
    Print() {
        //for each value, write it out until reaching null
    }

    Insert(int value) {
        //Determine the head node, if head is not null then
        //set our new node.Next to head
        //Then make the new node the head
    }

    bool Includes(int value) {
        //iterates through the linked list and checks whether or not the desired value matches the current value. If the iterator reaches the end (null) we return false.
    }
}


```

