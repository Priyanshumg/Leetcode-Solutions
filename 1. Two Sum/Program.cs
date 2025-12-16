using System.Globalization;

namespace _1._Two_Sum;

class Program
{

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        dict[nums[0]] = 0;

        for (int i = 1; i < nums.Length; i++)
            if (dict.ContainsKey(target - nums[i]))
                return new int[] { dict[target - nums[i]], i };
            else
                dict[nums[i]] = i;
        
        return new int[0];
    }

    public static void print(int[] arr)
    {
        Console.Write($"[ {arr[0]}");
        for (int i = 1; i < arr.Length; i++)
            if (i == arr.Length - 1)
                Console.WriteLine($" {arr[i]} ]");
            else
                Console.Write($"{arr[i]}, ");
    }
    
    static void Main(string[] args)
    {
        print(TwoSum(new int[] {2, 7, 11, 15}, 9));
        print(TwoSum(new int[] {3, 2, 4}, 6));
        print(TwoSum(new int[] {3, 3}, 6));
        
    }
}