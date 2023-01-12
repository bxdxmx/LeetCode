var s = new Solution();

s.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });

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
 
public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        TreeNode DFS(int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int m = left + (right - left) / 2;

            return new TreeNode(nums[m])
            {
                left = DFS(left, m - 1),
                right = DFS(m + 1, right)
            };
        }

        return DFS(0, nums.Length - 1);
    }
}
