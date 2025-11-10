using Xunit;
namespace _108._Convert_Sorted_Array_to_Binary_Search_Tree;

class Program
{
    /// <summary>
    /// Use this function only if running application on version 8 and above
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public TreeNode SortedArrayToBST8andUp(int[] nums) {
        if (nums.Length <= 0)
            return null;

        int mid = nums.Length / 2;
        var tree = new TreeNode(nums[mid]);
        tree.left = SortedArrayToBST(nums[..mid]);
        tree.right = SortedArrayToBST(nums[(mid + 1)..]);

        return tree;
    }

    public TreeNode SortedArrayToBST(int[] nums) 
    {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }

    public TreeNode SortedArrayToBST(int[] nums, int start, int end) {
        if (start > end)
            return null;

        int mid = (start + end) / 2;
        var tree = new TreeNode(nums[mid]);
        tree.left = SortedArrayToBST(nums, start, mid - 1);
        tree.right = SortedArrayToBST(nums, mid + 1, end);

        return tree;
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
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}