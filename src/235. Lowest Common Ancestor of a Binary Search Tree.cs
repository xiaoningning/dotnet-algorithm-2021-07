/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root.val < p.val && root.val < q.val)
            return LowestCommonAncestor(root.right, p, q);
        else if (root.val > p.val && root.val > q.val)
            return LowestCommonAncestor(root.left, p, q);
        else return root;
    }
    // Generic B tree
    public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null || root.val == p.val || root.val == q.val) return root;
        
        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);
        if (left != null && right != null) return root;
        else return left != null ? left : right;
    }
}
