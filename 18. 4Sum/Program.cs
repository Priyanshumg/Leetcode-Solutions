namespace _18._4Sum;

class Program
{
    public static IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums.Length < 4)
            return result;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;
               
                int start = j + 1;
                int end = nums.Length - 1;

                while (start < end)
                {
                    long sum = (long)nums[i] + nums[j] + nums[start] + nums[end];
                    if (sum == target)
                    {
                        result.Add(new int[] { nums[i], nums[j], nums[start], nums[end] });
                        while (start < end && nums[start] == nums[start + 1])
                            start++;

                        while (start < end && nums[end] == nums[end - 1])
                            end--;
                        start++;
                        end--;
                    }
                    else if (sum < target)
                        start++;
                    else
                        end--;
                }
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        RunFourSumTests();
    }

    public static void RunFourSumTests()
    {
        var tests = new List<(int[] nums, int target, List<IList<int>> expected)>
        {
            (
                new int[] { 1, 0, -1, 0, -2, 2 },
                0,
                new List<IList<int>>
                {
                    new List<int> { -2, -1, 1, 2 },
                    new List<int> { -2, 0, 0, 2 },
                    new List<int> { -1, 0, 0, 1 }
                }
            ),
            (
                new int[] { 2, 2, 2, 2, 2 },
                8,
                new List<IList<int>>
                {
                    new List<int> { 2, 2, 2, 2 }
                }
            ),
            (
                new int[] { 0, 0, 0, 0 },
                0,
                new List<IList<int>>
                {
                    new List<int> { 0, 0, 0, 0 }
                }
            ),
            (
                new int[] { -3, -2, -1, 0, 0, 1, 2, 3 },
                0,
                new List<IList<int>>
                {
                    new List<int> { -3, -2, 2, 3 },
                    new List<int> { -3, -1, 1, 3 },
                    new List<int> { -3, 0, 0, 3 },
                    new List<int> { -3, 0, 1, 2 },
                    new List<int> { -2, -1, 0, 3 },
                    new List<int> { -2, -1, 1, 2 },
                    new List<int> { -2, 0, 0, 2 },
                    new List<int> { -1, 0, 0, 1 }
                }
            ),
            (
                new int[] { 1, 2, 3, 4 },
                100,
                new List<IList<int>>() // empty expected
            )
        };
        
        int testNumber = 1;

        foreach (var t in tests)
        {
            var output = FourSum(t.nums, t.target);

            bool passed = CompareResults(output, t.expected);

            Console.WriteLine($"Test {testNumber++}: {(passed ? "PASS" : "FAIL")}");

            if (!passed)
            {
                Console.WriteLine("Input nums: [" + string.Join(",", t.nums) + "]");
                Console.WriteLine("Target: " + t.target);

                Console.WriteLine("Expected:");
                PrintList(t.expected);

                Console.WriteLine("Got:");
                PrintList(output);

                Console.WriteLine("--------------------------------------------------");
            }
        }
    }

    public static bool CompareResults(IList<IList<int>> a, IList<IList<int>> b)
    {
        if (a.Count != b.Count) return false;

        var setA = a.Select(x => string.Join(",", x)).ToHashSet();
        var setB = b.Select(x => string.Join(",", x)).ToHashSet();

        return setA.SetEquals(setB);
    }

    public static void PrintList(IList<IList<int>> list)
    {
        Console.Write("[");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write("[" + string.Join(",", list[i]) + "]");
            if (i < list.Count - 1) Console.Write(", ");
        }

        Console.WriteLine("]");
    }
}