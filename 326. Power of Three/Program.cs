namespace _326._Power_of_Three;

class Program
{
    public static bool IsPowerOfThree(int n) {
        if (n == 1)
            return true;
        if (n <= 0 || n % 3 != 0)
            return false;
        return IsPowerOfThree(n / 3);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfThree(27));
        Console.WriteLine(IsPowerOfThree(45));
        Console.WriteLine(IsPowerOfThree(-1));
        Console.WriteLine(IsPowerOfThree(0));
        Console.WriteLine(IsPowerOfThree(81));
    }
}