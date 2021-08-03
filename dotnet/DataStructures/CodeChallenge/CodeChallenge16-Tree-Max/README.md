

# Max Trees
Find the maximum number in the binary tree.

## Challenge
Given a binary tree, find the maximum value inside of the tree.

## Approach & Efficiency
The Time and Space are both linear in this problem as for every iteration of a node, one thing is traversed.

## Whiteboard Process
![Whiteboard](./Code-Challenge-16.png)

## API
There is only one function this time around - The idea behind the logic is: traverse through the tree and keep checking to see
if the value that was returned is equal to the current node (recursively). If it is, then we set the current max value to that node. This occurs for every node in the sequence.
