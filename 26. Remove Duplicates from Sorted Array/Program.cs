namespace _26._Remove_Duplicates_from_Sorted_Array;

class Program
{
    public static int RemoveDuplicates(int[] nums)
    {
        int slowPtr = 0;

        for (int fastPtr = 1; fastPtr < nums.Length; fastPtr++)
        {
            if (nums[fastPtr] != nums[slowPtr])
            {
                slowPtr++;
                nums[slowPtr] = nums[fastPtr];
            }        
        }
        return slowPtr + 1;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveDuplicates(new[] { 1, 2, 2, 3, 4, 5, 5 ,6}));
    }
}