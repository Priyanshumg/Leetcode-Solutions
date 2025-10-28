namespace _217._Contains_Duplicate;

class Program
{
    public static bool ContainsDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        foreach (var element in nums){
            if (hash.Contains(element)) return true;
            hash.Add(element);
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
        Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
        Console.WriteLine(ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
    }
}