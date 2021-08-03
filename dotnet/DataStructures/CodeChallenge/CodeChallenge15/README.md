# Trees


## Challenge
Challenge - create a binary tree that is able to perform PreOrder, InOrder and PostOrder sort. Additionally, 
create a binary search tree that can add nodes to the tree - as well as figure out whether or not a tree contains a specific value.


## Approach & Efficiency
The Time and Space are both linear in this problem as for every iteration of a node, one thing is traversed.

## API
Pre-Order Traversal() - Sort all nodes in a binary tree, start by adding the value of the parent nodes, then left, then right
In-Order Traversal() - Sort all nodes in a binary tree , start by adding the value of the left, then parent, then right
Post-Order Traversal() Sort all nodes in a binary tree, start by adding the value of the left, then right, then parent

Binary Search Add() - Adds a node in a binary search tree based on the value of the node (lower goes left, higher goes right)
Binary Search Contains() - Determine whether or not a value exists inside of the binary search tree.
