namespace _41._First_Missing_Positive;

class Program
{
    private static int FirstMissingPositive(int[] nums)
    {
        var n = nums.Length;
        var seen = new bool[n + 1];
        foreach (var element in nums)
            if (element <= n && element > 0)
                seen[element] = true;
        
        for(int i = 1; i <= n; i++)
            if (!(seen[i]))
                return i;
        
        return n + 1;
    }
    private static void Main(string[] args)
    {
        int[] nums = [1, 2, 0];
        int[] nums2 = [3, 4, -1, 1];
        int[] nums3 = [7, 8, 9, 11, 12];
        Console.WriteLine(FirstMissingPositive(nums));
        Console.WriteLine(FirstMissingPositive(nums2));
        Console.WriteLine(FirstMissingPositive(nums3));
    }
}