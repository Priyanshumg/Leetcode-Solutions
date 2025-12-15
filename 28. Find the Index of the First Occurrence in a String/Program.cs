namespace _28._Find_the_Index_of_the_First_Occurrence_in_a_String;

class Program
{
    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; ++i)
        {
            if (haystack.Substring(i, needle.Length) == needle)
                return i;
        }
        return -1;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(StrStr("sadbutsad", "sad"));
        Console.WriteLine(StrStr("Leetcode", "leeto"));
        Console.WriteLine(StrStr("a", "a"));
    }
}