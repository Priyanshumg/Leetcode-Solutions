namespace _75._Sort_Colors;

class Program
{
    public static void SortColors(int[] nums)
    {
        for (int i = 0; i <nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[j] < nums[i])
                    (nums[j], nums[i]) = (nums[i], nums[j]);
    }
    static void Main(string[] args)
    {
        int[] nums = [2, 0, 2, 1, 1, 0];
        SortColors(nums);
        foreach (var element in nums)
            Console.Write(element +  ", ");
    }
}