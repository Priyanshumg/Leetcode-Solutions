using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Debug_Console_Application;

public class Program
{
    public class LCPBenchmarks
    {
        private readonly string[][] _tests =
        [
            new[] { "flower", "flow", "flight" },
            new[] { "dogcar", "racecar", "car" },
            new[] { "interstellar", "internet", "internal" },
            new[] { "aa", "a" }
        ];

        [Benchmark]
        public string Approach_Sort()
        {
            return Program.LongestCommonPrefix(_tests[0]);
        }

        [Benchmark]
        public string Approach_Shrink()
        {
            return Program.LongestCommonPrefix2(_tests[0]);
        }
    }
    record TestCase(string[] input, string expectedResult); 
    public static void Main(string[] args)
    {

        BenchmarkRunner.Run<LCPBenchmarks>();
        // TestCase[] testcases = 
        // [
        //     new (["flower", "flow", "flight"], "fl"),
        //     new (["dogcar", "racecar", "car"], "")
        // ];
        //
        // foreach (var test in testcases)
        // {
        //     PrintInput(test.input);
        //     Console.WriteLine($"Output: {LongestCommonPrefix(test.input)}");
        //     Console.WriteLine($"Expected Res: {test.expectedResult}");
        //     Console.WriteLine(new string('=', 40));
        //     Console.WriteLine();
        // }
    }

    public static void PrintInput(string[] strs)
    {
        Console.Write("Test Input: [ ");
        foreach (var element in strs)
        {
            if (element == strs[^1])
            {
                Console.WriteLine(element + " ]");
                break;
            }
            Console.Write(element + ", ");
        }
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        strs = strs.OrderBy(s => s).ToArray();
        string first = strs[0], last = strs[^1];
        int index = 0;
        while (index <= first.Length && index <= last.Length)
        {
            if (first[index] == last[index])
                index++;

            else
                break;
        }

        return first.Substring(0, index);
    }

    
    public static string LongestCommonPrefix2(string[] strs)
    {
        string cmp = strs[0];
        foreach (string x in strs)
        {
            if(cmp.Length >= x.Length)
                cmp = x;
        }

        for (int i = 0; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(cmp))
            {
                cmp = cmp.Substring(0, cmp.Length - 1);
                if (cmp == "")
                    return "";
            }
        }

        return cmp;
    }

    // public static string LongestPalindrome(string s)
    // {
    //     if (s.Length <= 1)
    //         return s;
    //
    //     int longestStart = 0, longestLength = 0;
    //
    //     for (int i = 0; i < s.Length; i++)
    //     {
    //         // if (longestStart == 0 && longestLength == s.Length - 1) return s.Substring(longestLength, longestLength);
    //         int oddLength = ExpandAroundCenter(s, i, i), 
    //             evenLength = ExpandAroundCenter(s, i, i + 1),
    //             currentMax = Math.Max(oddLength, evenLength);
    //
    //         if (currentMax > longestLength)
    //         {
    //             // Saving Longest Palindromic index length
    //             longestLength = currentMax;
    //             // Getting Start Index of Longest Max
    //             longestStart = i - (currentMax - 1) / 2;
    //         }
    //     }
    //
    //     return s.Substring(longestStart, longestLength);
    // }
    //
    // private static int ExpandAroundCenter(string s, int left, int right)
    // {
    //     while (left >= 0 && right < s.Length && s[left] == s[right])
    //     {
    //         left--;
    //         right++;
    //     }
    //     return right - left - 1;
    // }
}
