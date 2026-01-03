namespace _49._Group_Anagrams;

class Program
{
    public static IList<IList<string>> GroupAnagrams1(string[] strs)
    {
        Dictionary<string, List<string>> map = [];
        foreach (var word in strs)
        {
            var chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key))
                map[key] = new List<string>();
            
            map[key].Add(word);
        }

        return map.Values.ToArray<IList<string>>();
    }
    
    
    
    // Most Optimized Solution
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = [];
        for (int i = 0; i < strs.Length; i++)
        {
            var s = strs[i];
            var charfreq = new char[26];
            foreach (var c in s)
                charfreq[c - 'a']++;

            var key = new string(charfreq);
            if (!map.ContainsKey(key))
                map[key] = [];
            
            map[key].Add(s);
        }

        return map.Values.ToList<IList<string>>();
    }
    static void PrintResult(string title, IList<IList<string>> result)
    {
        Console.WriteLine(title);
        foreach (var group in result)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }
        Console.WriteLine(new string('-', 40));
    }

    static void Main(string[] args)
    {
        var tests = new List<string[]>
        {
            new[] { "eat", "tea", "ate" },
            new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
            new[] { "", "", "a" },
            new[] { "a", "b", "a", "c", "b" },
            new[] { "aab", "aba", "baa", "ab", "ba" },
            new[] { "abc", "def", "ghi" },
            new[] { "zzz", "zz", "z", "zzz" }
        };

        foreach (var test in tests)
        {
            PrintResult("Sorted Key Solution:", GroupAnagrams1(test));
            PrintResult("Frequency Signature Solution:", GroupAnagrams(test));
        }
    }

}