namespace _5._Longest_Palindromic_Substring;

class Program
{
    static void Main(string[] args)
    {
        LongestPalindrome("RaceCar");
        LongestPalindrome("ABABCD");
        LongestPalindrome("cbbd");
    }
    public static bool IsPalindrope(string str)
    {
        string reverse = new string (str.ToLower().Reverse().ToArray());
        return reverse == str.ToLower();
    }
    
    public static void LongestPalindrome(string str) {
        str = str.ToLower();
        string substring = string.Empty; 
        int maxlength = 0;
        for (int start = 0; start <= str.Length; start++)
        {
            string substr = string.Empty;
            for (int end = start; end < str.Length; end++)
            {
                substr += str[end];
                if (IsPalindrope(substr) && maxlength < Math.Max(maxlength, substr.Length))
                {
                    maxlength = Math.Max(maxlength, substr.Length);
                    substring = substr;
                }
            }
        }
        Console.WriteLine(substring);
    }
}