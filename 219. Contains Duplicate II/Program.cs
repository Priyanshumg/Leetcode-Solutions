namespace _219._Contains_Duplicate_II;

class Program
{
    public static bool ContainsNearbyDuplicate2(int[] nums, int k) {
        for (int start = 0; start < nums.Length; start++)
        {
            for (int end = start + 1; end < nums.Length; end++)
            {
                if (nums[start] == nums[end] && Math.Abs(end - start) <= k) return true;
            }
        }
        return false;
    }

    public static bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        HashSet<int> hash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.Contains(nums[i])) return true;
            hash.Add(nums[i]);
            if (hash.Count > k) hash.Remove(nums[i - k]);
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ContainsNearbyDuplicate(new[] { 1, 2, 3, 1 }, 3));
        Console.WriteLine(ContainsNearbyDuplicate(new[] { 1, 0, 1, 1 }, 1));
        Console.WriteLine(ContainsNearbyDuplicate(new[] { 1, 2, 3, 1, 2, 3 }, 2));
    }
}