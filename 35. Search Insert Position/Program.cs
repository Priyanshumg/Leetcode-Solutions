namespace _35._Search_Insert_Position;

class Program
{

    public static int SearchInsert(int[] nums, int target)
    {
        return SearchInsert(nums, target, 0, nums.Length - 1);
    }

    public static int SearchInsert(int[] nums, int target, int start, int end)
    {
        if (start > end)
            return start;

        int mid = start + (end - start) / 2;

        if (nums[mid] == target)
            return mid;
        else if (nums[mid] > target)
            return SearchInsert(nums, target, start, mid - 1);
        else
            return SearchInsert(nums, target, mid + 1, end);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(SearchInsert(new int[] {1, 3, 5, 6},5));
        Console.WriteLine(SearchInsert(new int[] {1, 3, 5, 6},2));
        Console.WriteLine(SearchInsert(new int[] {1, 3, 5, 6},7));
    }
}