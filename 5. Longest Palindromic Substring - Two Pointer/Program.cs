namespace _5._Longest_Palindromic_Substring___Two_Pointer;

class Program
{
    static void Main(string[] args)
    {
        string[] testCases = { "babad", "cbbd", "a", "ac", "racecar", "abba", "abcdef" };
        string[] expected = { 
            "Expected: 'bab' or 'aba'",
            "Expected: 'bb'",
            "Expected: 'a'",
            "Expected: 'a' or 'c'",
            "Expected: 'racecar'",
            "Expected: 'abba'",
            "Expected: any single char"
        };
        
        Console.WriteLine("Testing Longest Palindromic Substring:\n");
        
        for (int i = 0; i < testCases.Length; i++)
        {
            string result = LongestPalindrome(testCases[i]);
            Console.WriteLine($"Input: '{testCases[i]}'");
            Console.WriteLine($"Output: '{result}'");
            Console.WriteLine($"{expected[i]}\n");
        }
    }

    public static string LongestPalindrome(string s)
    {
        if (s.Length <= 1)
            return s;

        int longestStart = 0, longestLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // if (longestStart == 0 && longestLength == s.Length - 1) return s.Substring(longestLength, longestLength);
            int oddLength = ExpandAroundCenter(s, i, i), 
                evenLength = ExpandAroundCenter(s, i, i + 1),
                currentMax = Math.Max(oddLength, evenLength);

            if (currentMax > longestLength)
            {
                // Saving Longest Palindromic index length
                longestLength = currentMax;
                // Getting Start Index of Longest Max
                longestStart = i - (currentMax - 1) / 2;
            }
        }

        return s.Substring(longestStart, longestLength);
    }

    private static int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
}