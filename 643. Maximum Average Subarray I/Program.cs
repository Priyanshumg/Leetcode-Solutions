namespace _643._Maximum_Average_Subarray_I;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int windowSize = 3;
        FindMaxAverage2(nums, windowSize);
    }
    
    /// <summary>
    /// Least Optimized one, Good for understanding one way of iteration in an siding widos
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="windowSize"></param>
    public static void FindMaxAverage1(int[] nums, int windowSize)
    {   
        if (nums == null || nums.Length == 0 || windowSize > nums.Length) return;
        double maxAverage = double.MinValue;
        int start = 0;
        
        for (start = 0; start <= nums.Length - windowSize; start++)
        {
            double sum = 0;
            Console.Write("WindowSize: [ ");
            for (int end = start; end < windowSize + start; end++)
            {
                Console.Write(nums[end] + " ");
                sum += nums[end];
            }
            maxAverage = Math.Max(maxAverage, sum/ windowSize);
            Console.WriteLine($"], Max Average: {maxAverage} ");
        }
        Console.WriteLine($"Max Average: {maxAverage}");
    }
    
    /// <summary>
    /// Most Optimized one, Little tricky to understand at first but debugging this would be helpful to understand logics
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="windowSize"></param>
    public static void FindMaxAverage2(int[] nums, int windowSize)
    {   
        if (nums == null || nums.Length == 0 || windowSize > nums.Length) return;
        int sum = 0;
        for (int i = 0; i < windowSize; i++)
        {
            sum += nums[i];
        }

        double maxSum = sum;
        
        int startIndex = 0;
        int endIndex = windowSize;
        
        while (endIndex < nums.Length)
        {
            sum -= nums[startIndex];
            startIndex++;
            
            sum += nums[endIndex];
            endIndex++;
            maxSum = Math.Max(maxSum, sum);
        }
        Console.WriteLine($"Max Average: {maxSum / windowSize}");
    }
}