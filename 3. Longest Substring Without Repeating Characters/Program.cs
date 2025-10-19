namespace _3._Longest_Substring_Without_Repeating_Characters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
        Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
    }
    public static int LengthOfLongestSubstring(string str) {
        int start = 0, maxLength = 0;
        HashSet<char> charSet = new HashSet<char>();
        for (int end = 0; end < str.Length; end++)
        {
            if (!charSet.Contains(str[end]))
            {
                charSet.Add(str[end]);
            }
            else
            {
                while (charSet.Contains(str[end]))
                {
                    charSet.Remove(str[start]);
                    start++;
                }
                charSet.Add(str[end]);
            }
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        return maxLength;
    }
}