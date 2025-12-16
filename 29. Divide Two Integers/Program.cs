namespace _29._Divide_Two_Integers;

class Program
{
    public static int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
            return int.MaxValue;
        
        long dvd = Math.Abs((long)dividend);
        long dvs = Math.Abs((long)divisor);
        int result = 0;

        bool isNegative = (dividend < 0) ^ (divisor < 0);
        
        while (dvd >= dvs)
        {
            long temp = dvs;
            int multiple = 1;

            while (dvd >= (temp <<= 1))
            {
                temp <<= 1;
                multiple <<= 1;
            }

            dvd -= temp;
            result += multiple;
        }
        
        return isNegative ? -result : result;
    }
    static void Main()
    {
        Console.WriteLine(Divide(10, 3));
        Console.WriteLine(Divide(7, -3));
        Console.WriteLine(Divide(-2147483648, -1));
    }
}