namespace _3._Longest_Substring_Without_Repeating_Characters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstringv2("abcabcbb"));
        Console.WriteLine(LengthOfLongestSubstringv2("bbbbb"));
        Console.WriteLine(LengthOfLongestSubstringv2("pwwkew"));
    }
    
    public static int LengthOfLongestSubstringv2(string str)
    {
        int start = 0, MaxCharLen = 0;
        HashSet<char> set = new HashSet<char>();
        for (int end = start; end <= str.Length - 1; end++)
        {
            while(set.Contains(str[end]))
            {
                set.Remove(str[start]);
                start++;
            }
            set.Add(str[end]);
            MaxCharLen = Math.Max(MaxCharLen, set.Count);
        } 
        return MaxCharLen;
    }
    
    public static int LengthOfLongestSubstringv1(string str) {
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