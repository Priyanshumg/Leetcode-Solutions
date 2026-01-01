using System.Runtime.InteropServices.JavaScript;

namespace _34._Find_First_and_Last_Position_of_Element_in_Sorted_Array;

class Program
{
    public static int[] SearchRange(int[] nums, int target)
    { 
        return [FindFirst(nums, target), FindLast(nums, target)];
    }

    public static int FindFirst(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1, ans = -1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                ans = mid;
                end = mid - 1;
            }
            else if (target > nums[mid])
                start = mid + 1;
            else
                end = mid - 1;
        }
        return ans;
    }

    public static int FindLast(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1, ans = -1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                ans = mid;
                start = mid + 1;
            }
            else if (target > nums[mid])
                start = mid + 1;
            else
                end = mid - 1;
        }
        return ans;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(",", SearchRange(new int[]{5,7,7,8,8,10}, 8))); // [3,4]
        Console.WriteLine(string.Join(",", SearchRange(new int[]{5,7,7,8,8,10}, 6))); // [-1,-1]
        Console.WriteLine(string.Join(",", SearchRange(new int[]{1}, 1)));           // [0,0]
        Console.WriteLine(string.Join(",", SearchRange(new int[]{1,2,3,3,3,4}, 3))); // [2,4]
        Console.WriteLine(string.Join(",", SearchRange(new int[]{2,2}, 2)));         // [0,1]

    }
}