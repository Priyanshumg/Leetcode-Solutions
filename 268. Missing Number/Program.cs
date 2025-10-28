namespace _268._Missing_Number;

class Program
{
    public static int MissingNumber(int[] nums)
    {
        IEnumerable<int> range = Enumerable.Range(0, nums.Max());
        foreach (var element in range)
        {
            if (!nums.Contains(element)) return element;
        }
        return nums.Length;
    }
    public static int MissingNumberV2(int[] nums)
    {
        int sum = 0;
        for (int i = 1; i <= nums.Length; i++)
        {
            sum += i;
            sum = sum - nums[i - 1];
        }

        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(MissingNumberV2(new[] { 3, 0, 1 }));
        Console.WriteLine(MissingNumberV2(new[] { 0, 1 }));
        Console.WriteLine(MissingNumberV2(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
    }
}