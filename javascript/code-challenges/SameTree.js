// BASIC IDEA
// check if the root node p equals q.
// if both treenode p and q are null, return.
// if, at any time, treenode is not equal to treenode p, we return false.

// recursively call into tree node p.left, passing in treenode q.left as well.
// recursively call into tree node p.right, if it exists. passing in q.right as well.

// If end of recursive call is reached without returning false, return true. 
// this problem is considered pre-order traversal as the root node is visited first, then left, then right.

class TreeNode(val, left, right) {
  this.val = (val === undefined ? 0 : val);
  this.left = (left === undefined ? 0: left);
  this.right = (right === undefined ? 0: right);
}

const isSameTree = function(p, q) {
  
  // isSame will be used and returned at the very end of the call stack.
  recursiveCall(p, q, isSame);
  return isSame;
};

const recursiveCall = (p, q, isSame) => {
  if (p === null && q === null) return 0;
  if (p !== q || p === null && q !== null || q === null && p !== null){
    isSame = false;
    return 0;
  }

  recursiveCall(p.left, q.left);
  recursiveCall(p.right, q.right);
  return 0;
};