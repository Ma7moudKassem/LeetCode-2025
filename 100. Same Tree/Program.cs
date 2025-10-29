﻿bool IsSameTree(TreeNode p, TreeNode q)
{
    if (p is null && q is null)
        return true;
    else if(p is null || q is null)
        return false;
    else if(q.val != p.val)
        return false;

    bool left = IsSameTree(p.left, q.left);
    bool right = IsSameTree(p.right, q.right);

    return left && right;
}



public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}