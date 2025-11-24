using System.Reflection.Metadata;

namespace _17._Letter_Combinations_of_a_Phone_Number;

class Program
{
    static readonly Dictionary<char, string> phone = new Dictionary<char, string>() {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };
    
    static void Main(string[] args)
    {  
        Console.WriteLine("TestCase: 23");
        List<string> result = LetterCombinations("23").ToList();
        printResult(result);
        Console.WriteLine();

        Console.WriteLine("TestCase: 2");
        result = LetterCombinations("2").ToList();
        printResult(result);
        Console.WriteLine();
        
        Console.WriteLine("TestCase: empty string");
        result = LetterCombinations("").ToList();
        printResult(result);
        Console.WriteLine();
    }

    public static void printResult(List<string> result)
    {
        if (result.Count == 0)
            Console.WriteLine("Printing Result: []");
        else
        {
            Console.Write("Printing Result: [ ");
            foreach (var element in result)
            {
                if (element == result[^1])
                    Console.Write(element + " ]");
                else
                    Console.Write(element + ", ");
            }
        }
        Console.WriteLine();
    }

    public static IList<string> LetterCombinations(string digits)
    {
        List<string> result = new List<string>();
        if (string.IsNullOrEmpty(digits))
            return result;

        backtrack(0, "", digits, result);
        return result;
    }

    public static void backtrack(int index, string path,string digits, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(path);
            return;
        }
        
        foreach (var element in phone[digits[index]])
            backtrack(index + 1, path + element, digits, result);
    }
}