using System.Collections.Immutable;

namespace _15._3Sum;
class Program
{
    record TestCases(int[] input, List<IList<int>> output);

    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        nums = nums.OrderBy(k => k).ToArray();
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                IList<int> lst = new List<int>();
                if (j + 1 < nums.Length && nums[i] + nums[j] + nums[j + 1] == 0)
                {
                    lst.Add(nums[i]);
                    lst.Add(nums[j]);
                    lst.Add(nums[j + 1]);
                    lst = lst.OrderBy(l => l).ToImmutableList();
                }

                if (lst.Any() && !result.Any(r => r.SequenceEqual(lst)))
                    result.Add(lst);
            }
        }

        return result;
    }
    
    public static IList<IList<int>> ThreeSumv2(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0)
                break;
            // IMPORTANT: This will help you remove
            // any duplicate entry from the result
            if (i > 0 && nums[i] == nums[i - 1])
                continue; 

            int left = i + 1, right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new int[] { nums[i], nums[left], nums[right] });

                    // skip duplicates for left and right
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }

    static void PrintResult(IList<IList<int>> result)
    {
        foreach (var element in result)
        {
            Console.Write("[ ");
            for (int i = 0; i < element.Count; i++)
            {
                if (i == element.Count - 1)
                    Console.WriteLine(element[i] + " ]");
                else
                    Console.Write(element[i] + ", ");
            }
        }
        if (result.Count == 0)
            Console.WriteLine("[ ]");
    }

    static void Main(string[] args)
    {
        TestCase();
    }

    public static void TestCase()
    {
        var testCases = new List<TestCases>
        {
            new TestCases(
                new int[] { -1, 0, 1, 2, -1, -4 },
                new List<IList<int>>
                {
                    new List<int>{ -1, -1, 2 },
                    new List<int>{ -1, 0, 1 }
                }
            ),

            new TestCases(
                new int[] { 0, 1, 1 },
                new List<IList<int>>() // no triplets
            ),

            new TestCases(
                new int[] { 0, 0, 0 },
                new List<IList<int>>
                {
                    new List<int>{ 0, 0, 0 }
                }
            ),

            new TestCases(
                new int[] { 0, 0, 0, 0 },
                new List<IList<int>>
                {
                    new List<int>{ 0, 0, 0 }
                }
            ),

            new TestCases(
                new int[] { -100, -70, -60, 110, 120, 130, 160 },
                new List<IList<int>>
                {
                    new List<int>{ -100, -60, 160 },
                    new List<int>{ -70, -60, 130 }
                }
            )
        };

        foreach (var test in testCases)
            checkAndValidate(test.input, test.output);
    }

    public static void checkAndValidate(int[] input, List<IList<int>> expected)
    {
        Console.Write("\nInput = [ ");
        for (int i = 0; i < input.Length; i++)
        {
            if (i == input.Length - 1)
                Console.WriteLine(input[i] + " ]");
            else
                Console.Write(input[i] + ", ");
        }

        Console.WriteLine("Output:");
        var output = ThreeSumv2(input);
        PrintResult(output);

        Console.WriteLine("Expected:");
        PrintResult(expected);

        Console.WriteLine("------------------------------------");
    }
}
