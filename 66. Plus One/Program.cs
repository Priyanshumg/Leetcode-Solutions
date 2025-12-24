namespace _66._Plus_One;

class Program
{
    public static int[] PlusOne(int[] nums)
    {
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] + 1 != 10)
            {
                nums[i] += 1;
                return nums;
            }
            nums[i] = 0;
        }

        int[] arr = new int[nums.Length + 1];
        arr[0] = 1;
        return arr;
    }

    public static void printArr(int[] arr)
    {
        Console.Write("Arr = [ ");
        for(int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
                Console.WriteLine($"{arr[i]} ]");
            else
                Console.Write($"{arr[i]}, ");
        }
    }
    
    
    static void Main(string[] args)
    {
        int[] input1 = new[] { 1, 2, 3 };
        Console.Write("Printing Input:  ");
        printArr(input1);

        var output = PlusOne(input1);
        Console.Write("Printing Output: ");
        printArr(output);
        
        Console.WriteLine();
        
        input1 = new[] { 9, 9 };
        Console.Write("Printing Input:  ");
        printArr(input1);

        output = PlusOne(input1);
        Console.Write("Printing Output: ");
        printArr(output);
    }
}