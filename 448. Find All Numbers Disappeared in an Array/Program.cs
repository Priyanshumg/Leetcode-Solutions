namespace _448._Find_All_Numbers_Disappeared_in_an_Array;

class Program
{
    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> lst = new List<int>();
        foreach (var elements in Enumerable.Range(nums.Min(), nums.Max()))
        {
            if (!nums.Contains(elements)) lst.Add(elements);
        }

        if (lst.Count == 0)
        {
            lst.Add(nums.Length);
            return lst;
        }
        return lst;
    }

    public static void PrintArr(IList<int> arr)
    {
        Console.Write("[ ");
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("]");
    }
    static void Main(string[] args)
    {
        PrintArr(FindDisappearedNumbers( new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }));
        PrintArr(FindDisappearedNumbers(new int[] { 1, 1 }));
    }
}