// Single line using spread operator
return root ? [...inorderTraversal(root.left), root.val, ...inorderTraversal(root.right)] : [];