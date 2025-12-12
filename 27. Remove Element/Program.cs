namespace _27._Remove_Element;

class Program
{
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
        Console.WriteLine(RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
    }
}