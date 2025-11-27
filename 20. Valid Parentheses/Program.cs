namespace _20._Valid_Parentheses;

class Program
{
    static readonly string[] tests = {
        "()",       // valid
        "()[]{}",   // valid
        "(]",       // invalid
        "([)]",     // invalid
        "{[]}",     // valid
        "((()))",   // valid
        "((())",    // invalid
        "",         // valid (empty string)
        "]",        // invalid
        "(((((())))))", // valid
        "{[()()]}", // valid
        "{[()()]]", // invalid
        "(a)",      // invalid (invalid char)
        "[",        // invalid
        "{[]})",    // invalid
    };
    public static bool IsValid(string s)
    {
        char[] stack = new char[s.Length];
        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '(' || c == '[' || c == '{')
            {
                stack[index] = c;
                index++;
            }
            else if (index == 0 ||
                     (c == ')' && stack[index - 1] != '(') ||
                     (c == '}' && stack[index - 1] != '{') ||
                     (c == ']' && stack[index - 1] != '['))
                return false;
            else
                index--;
        }

        return index == 0;
    }
    static void Main(string[] args)
    {
        foreach (var test in tests)
        {
            bool result = IsValid(test);
            Console.WriteLine($"{test,-15} -> {result}");
        }
    }
}