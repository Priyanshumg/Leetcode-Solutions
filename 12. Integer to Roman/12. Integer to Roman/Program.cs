namespace _12._Integer_to_Roman;

class Program
{
    readonly string[] ones = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
    readonly string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    readonly string[] hrns = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    readonly string[] ths = new string[] { "", "M", "MM", "MMM" };

    public string IntToRoman(int num) {
        return ths[num / 1000] + hrns[(num % 1000) / 100] + tens[(num % 100) / 10] + ones[num % 10];
    }
    
    public static void Main(string[] args)
    {
        Program prg = new Program();
        Console.WriteLine(prg.IntToRoman(123));
    }
}