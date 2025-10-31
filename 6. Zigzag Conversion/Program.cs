namespace _6._Zigzag_Conversion;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Convert("PAYPALISHIRING", 3));
    }

    public static string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        var result = new System.Text.StringBuilder();
        int cycleLen = 2 * numRows - 2;

        for (int row = 0; row < numRows; row++)
        {
            for (int i = row; i < s.Length; i += cycleLen)
            {
                result.Append(s[i]);

                int diagonalIndex = i + cycleLen - 2 * row;
                if (row != 0 && row != numRows - 1 && diagonalIndex < s.Length)
                    result.Append(s[diagonalIndex]);
            }   
        }
        return result.ToString();
    }
}