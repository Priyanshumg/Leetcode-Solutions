namespace _14._Longest_Common_Prefix;

class Program
{
    record TestCase(string[] input, string expectedResult); 
    static void Main(string[] args)
    {

        TestCase[] testcases = 
        [
            new (["flower", "flow", "flight"], "fl"),
            new (["dogcar", "racecar", "car"], "")
        ];

        foreach (var test in testcases)
        {
            PrintInput(test.input);
            Console.WriteLine($"Output: {LongestCommonPrefixV2(test.input)}");
            Console.WriteLine($"Expected Res: {test.expectedResult}");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine();
        }
    }

    static void PrintInput(string[] strs)
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
    static string LongestCommonPrefix(string[] strs)
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
    
    static string LongestCommonPrefixV2(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        string prefix = strs[0];
        for (int i = 0; i < strs.Length; i++)
            while (!strs[i].StartsWith(prefix))
                prefix = prefix.Substring(0, prefix.Length - 1);

        return prefix;
    }
}