namespace _8._String_to_Integer___ATOI;

class Program
{
    public static int MyAtoi(string s)
    {
        try
        {
            if (string.IsNullOrEmpty(s) || s.Length <= 0)
                return 0;

            int index = 0;
            while (index < s.Length && s[index] == ' ')
                index++;
            

            bool isNegative = false;
            if (index < s.Length && (s[index] == '+' || s[index] == '-'))
            {
                if (s[index] == '-')
                    isNegative = true;
                index++;
            }

            int result = 0;
            while (index < s.Length && char.IsDigit(s[index]))
            {
                // This will give you ascii converted into int value
                int digit = s[index] - '0';

                // this will return max value of integer based on the sign which is given as a input 
                if (result > (int.MaxValue - digit) / 10)
                    return isNegative ? int.MinValue : int.MaxValue;

                // Every Iteration you will be getting a digit
                // and that digit will be multiplied by 10
                // and get added by new digit, so you are constructing 
                // new number every iterations say 123
                // result = 1 * 10 + digit(2) = 10 + 2 = 12
                // result = 12 * 10 + digit (3) = 120 + 3 = 123
                result = result * 10 + digit;
                index++;
            }

            return isNegative ? -result : result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception Occured : {ex}");
            return 0;
        }
    }
    static void Main(string[] args)
    {
        // Running Manual Cases
        Console.WriteLine("Running given cases for validation".ToUpper());
        Console.WriteLine($"Input: '42', Output: {MyAtoi("42")}, Expected: |42|");
        Console.WriteLine($"Input: ' -042', Output: {MyAtoi(" -042")}, Expected: |-42|");
        Console.WriteLine($"Input: '1337c0d3', Output: {MyAtoi("1337c0d3")}, Expected: 1337");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine();
        Console.WriteLine("Running Other cases for validation");
        RunTests();
    }
    
    public static void RunTests()
    {
        var tests = new (string input, int expected)[]
        {
            ("42", 42),
            ("   -42", -42),
            ("4193 with words", 4193),
            ("words and 987", 0),
            ("-91283472332", int.MinValue),
            ("91283472332", int.MaxValue),
            ("+1", 1),
            ("00000-42a1234", 0),
            ("   +0 123", 0),
            ("", 0),
            ("   ", 0),
            ("-042", -42),
        };

        int passed = 0;
        foreach (var (input, expected) in tests)
        {
            int output = MyAtoi(input);
            bool isPass = output == expected;
            Console.WriteLine($"Input: '{input}' → Output: {output}, Expected: {expected} → {(isPass ? "✅ PASS" : "❌ FAIL")}");
            if (isPass) passed++;
        }
        Console.WriteLine($"\nPassed {passed}/{tests.Length} test cases.");
        Console.WriteLine(new string ('=', 50));
    }
}