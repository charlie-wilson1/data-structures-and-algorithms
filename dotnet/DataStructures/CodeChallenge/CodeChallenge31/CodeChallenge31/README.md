# Challenge Summary
Given a string, find the first repeated word inside the string and return it to the user.

## Whiteboard Process
<!-- Embedded whiteboard image -->

## Approach & Efficiency
O(n) linear time as well as O(n) linear space.

## Solution
The two major parts of this code are:
1. Using the contains method within Hashtables to search via key.
2. using a ternary to find out whether or not the key exists inside of the DB.

If the key does exist inside of the DB, then we know that we have already entered in that word and have found the first duplicate.
If not, then we simply create a key value pair and insert it into the hashtable for future reference.

