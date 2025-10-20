namespace _1768._Merge_Strings_Alternately;

class Program
{
    static void Main(string[] args)
    {
        MergeAlternately("abc", "pqr");
        MergeAlternately("ab", "pqrs");
        MergeAlternately("abcd", "pq");
    }
    
    public static void MergeAlternately(string word1, string word2) {
        string resultString = string.Empty;
        int wordLength = word1.Length > word2.Length ? word1.Length : word2.Length;
        for (int i = 0; i < wordLength; i++)
        {
            if (i < word1.Length) resultString += word1[i];
            if (i < word2.Length) resultString += word2[i];
        }
        Console.WriteLine(resultString);
    }
}