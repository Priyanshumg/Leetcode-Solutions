namespace _31._Next_Permutation;

class Program
{

    static void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int i = n - 2;
        
        // Checking second last element with the last element
        // Pivot is the point from which the element on left is decending order
        while (i >= 0 && nums[i] >= nums[i + 1])
            i--;

        if (i >= 0)
        {
            int j = n - 1;
            while (nums[j] <= nums[i])
                j--;

            (nums[i], nums[j]) = (nums[j], nums[i]);
        }
        Array.Reverse(nums, i + 1, n - (i + 1));
    }
    
    static void Main(string[] args)
    {
        int[] nums = [1,2,3];
        Console.Write("Before: ");
        print(nums);
        
        NextPermutation(nums);
        Console.Write("After:  ");
        print(nums);
    }

    static void print(int[] nums)
    {
        Console.Write("[ ");
        for (var i = 0; i < nums.Length; i++)
        {
            if (i == nums.Length - 1)
                Console.WriteLine($"{nums[i]} ]");
            else
                Console.Write($"{nums[i]}, ");
        }
    }
}