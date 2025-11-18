namespace _1752._Check_if_Array_Is_Sorted_and_Rotated;

class Program
{
    public static bool Check(int[] nums) => checkSorted(nums, 0);
    private static bool checkSorted(int[] nums, int count){
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] < nums[i - 1])
                count++;   
        
        if (nums[nums.Length - 1] > nums[0])
            count++;

        return count <= 1;
    }
    static void Main(string[] args)
    {
        int[][] tests = new int[][]
        {
            new int[]{3,4,5,1,2},
            new int[]{2,1,3,4},
            new int[]{1,2,3},
            new int[]{1,1,1},
            new int[]{6,10,6}
        };
        foreach (var arr in tests)
        {
            Console.Write("[" + string.Join(",", arr) + "] -> ");
            Console.WriteLine(Check(arr));
        }

    }
}
