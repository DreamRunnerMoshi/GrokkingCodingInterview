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
    public int ClosestValue(TreeNode root, double target) {
        
        return findClosest(root, target, root.val);
    }
    
    private int findClosest(TreeNode node, double target, int closestSoFar){
        
        if(node == null) return closestSoFar;
        
        int nodeValue = node.val;
        if(Math.Abs(target - nodeValue) < Math.Abs(closestSoFar - target)) {
            closestSoFar = nodeValue;
        }
        
        if(nodeValue-target > 0) return findClosest(node.left, target, closestSoFar);
        return findClosest(node.right, target, closestSoFar);
        
        return closestSoFar;
    }
    
}