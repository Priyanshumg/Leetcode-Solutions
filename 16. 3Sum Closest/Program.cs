namespace _16._3Sum_Closest;

class Program
{
    static int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int resultSum = nums[0] + nums[1] + nums[2], minDiff = int.MaxValue;
        for (int i = 0; i < nums.Length - 2; i++)
        { 
            int left = i + 1, right = nums.Length - 1;

            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == target)
                    return target;
                
                if (sum < 0)
                    left++;
                else
                    right--;

                int targetDiff = Math.Abs(sum - target);
                if (targetDiff < minDiff)
                {
                    resultSum = sum;
                    minDiff = targetDiff;
                }
            }
        }
        return resultSum;
    }
    static void Main(string[] args)
    {
        Test(new int[] { -1, 2, 1, -4 }, 1);
        Test(new int[] { 0, 0, 0 }, 1);
        Test(new int[] { 0, 1, 2 }, 3);
        Test(new int[] { 0, 1, 2 }, 0);

    }
    static void Test(int[] nums, int target)
    {
        int result = ThreeSumClosest(nums, target);
        Console.WriteLine($"Input: [{string.Join(",", nums)}], target = {target} ➝ Output: {result}");
    }

}