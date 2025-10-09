namespace Two_Sum_Problem;

class Program
{
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[0];
    }

    static void Main(string[] args)
    {
        #region Input Declaration Region
        // Sample inputs
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        
        int[] nums2 = { 3,2,4 };
        int target2 = 6;

        int[] nums3 = { 3, 3 };
        int target3 = 6;

        #endregion
        
        printOutput(nums, target);
        printOutput(nums2, target2);
        printOutput(nums3, target3);
    }

    public static void printOutput(int[] nums, int target)
    {
        var x = TwoSum(nums, target);
        Console.Write("[ ");
        foreach (var item in x) Console.Write($" {item} ");
        Console.WriteLine(" ]");
    }
}