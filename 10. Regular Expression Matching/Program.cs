namespace _10._Regular_Expression_Matching;

class Program
{
    public static bool isMatch(string s, string p)
    {
        return isMatchR(0, 0, s, p);
    }

    public static bool isMatchR(int i, int j, string s, string p)
    {
        if (j == p.Length)
            return i == s.Length;

        bool firstMatch = (i < s.Length && (s[i] == p[j] || p[j] == '.'));
        
        if (j + 1 < p.Length && p[j + 1] == '*')
            return isMatchR(i, j + 2, s, p) || (firstMatch && isMatchR(i + 1, j, s, p));
        else
            return firstMatch && isMatchR(i + 1, j + 1, s, p);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(isMatch("aa", "a"));
        Console.WriteLine(isMatch("aa", "a*"));
        Console.WriteLine(isMatch("ab", ".*"));
    }
}