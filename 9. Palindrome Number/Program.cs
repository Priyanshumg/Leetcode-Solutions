namespace _9._Palindrome_Number;

class Program
{
    public static int Reverse(int num)
    {   
        int result = 0;
        while (num != 0)
        {
            int digit = num % 10;

            bool x = result > (int.MaxValue - digit) / 10;
            bool y = result < (int.MinValue - digit) / 10;
            if (result > (int.MaxValue - digit) / 10 || result < (int.MinValue - digit) / 10)
                return 0;

            result = result * 10 + digit;
            num /= 10;
        }
        return result;
    }
    
    public static bool IsPalindrome(int x) {
        return x == Reverse(x);
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(121));
    }
}