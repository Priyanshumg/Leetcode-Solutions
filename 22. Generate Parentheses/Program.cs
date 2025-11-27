namespace _22._Generate_Parentheses;

class Program
{
    public static IList<string> GenerateParenthesis(int numberP)
    {
        IList<string> result = new List<string>();
        GenerateParenthesis(numberP, 0, 0, "", result);
        return result;
    }
    static void GenerateParenthesis(int n, int left, int right, string s, IList<string> result)
    {
        if (s.Length == n * 2){
            result.Add(s);
            return;
        }

        if (left < n)
            GenerateParenthesis(n, left + 1, right, s + "(", result);
        
        if (right < left)
            GenerateParenthesis(n, left, right + 1, s + ")", result);
    }
    
    static void Main(string[] args)
    {
        var tests = new Dictionary<int, List<string>>
        {
            { 0, new List<string> { "" } },
            { 1, new List<string> { "()" } },
            { 2, new List<string> { "()()", "(())" } },
            { 3, new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" } }
        };

        foreach (var kvp in tests)
        {
            int n = kvp.Key;
            var expected = kvp.Value;

            var actual = GenerateParenthesis(n);

            // sort both so order doesn't matter
            var expectedSorted = expected.OrderBy(x => x).ToList();
            var actualSorted = actual.OrderBy(x => x).ToList();

            bool passed = expectedSorted.SequenceEqual(actualSorted);

            Console.WriteLine($"Test n = {n}");
            Console.WriteLine($"Expected: [ {string.Join(", ", expectedSorted)} ]");
            Console.WriteLine($"Actual:   [ {string.Join(", ", actualSorted)} ]");
            Console.WriteLine(passed ? "✔ PASSED\n" : "❌ FAILED\n");
        }
    }

}