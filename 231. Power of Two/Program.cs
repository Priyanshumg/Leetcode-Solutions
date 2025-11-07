namespace _231._Power_of_Two;

class Program
{
    public static bool IsPowerOfTwo(int n) {
        if (n == 1)
            return true;
        
        if (n <= 0 || n % 2 == 1)
            return false;

        return IsPowerOfTwo(n / 2);
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfTwo(16));
        Console.WriteLine(IsPowerOfTwo(0));
        Console.WriteLine(IsPowerOfTwo(1));
        Console.WriteLine(IsPowerOfTwo(3));
    }
}