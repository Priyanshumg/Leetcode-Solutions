namespace _7._Reverse_Integer;

class Program
{
    public static int Reverse(int x) {
        int revNum = 0;
        while (x != 0)
        {
            int digit = x % 10;

            if (revNum > int.MaxValue / 10 || revNum < int.MinValue / 10)
                return 0;

            revNum = revNum * 10 + digit;
            x = x / 10;
        }
        return revNum;
    }
    static void Main(string[] args)
    {
        // LeetCode Test Cases: https://leetcode.com/problems/reverse-integer/
        Console.WriteLine($"Before: 123, After: {Reverse(123)}");
        Console.WriteLine($"Before: -123, After: {Reverse(-123)}");
        Console.WriteLine($"Before: 120, After: {Reverse(120)}");
    }
}