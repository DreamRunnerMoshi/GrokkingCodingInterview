/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode BstToGst(TreeNode root) {
        convert(root, 0);
        return root;
    }
    
    int convert(TreeNode node, int sumFromUp) {
        
        if(node == null) return 0;
        var sumRight = convert(node.right, sumFromUp);
        var nodePrevVal = node.val;
        node.val += sumRight + sumFromUp;
        var sumLeft = convert(node.left, node.val);
        
        return nodePrevVal + sumLeft + sumRight;
    }
    
}