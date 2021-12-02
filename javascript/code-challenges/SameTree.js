// BASIC IDEA
// check if the root node p equals q.
// if both treenode p and q are null, return.
// if, at any time, treenode is not equal to treenode p, we return false.

// recursively call into tree node p.left, passing in treenode q.left as well.
// recursively call into tree node p.right, if it exists. passing in q.right as well.

// If end of recursive call is reached without returning false, return true. 
// this problem is considered pre-order traversal as the root node is visited first, then left, then right.

const SameTree = (p, q) => {
  if (p !== q ) return false;
};
