// Single line using spread operator



let inorderTraversal = (root) => {
  return root ? [...inorderTraversal(root.left), root.val, ...inorderTraversal(root.right)] : [];
};
