namespace _11._Container_With_Most_Water;

class Program
{
    public static int MaxArea(int[] arr)
    {
        int left = 0, right = arr.Length - 1, max = 0;
        while (left < right)
        {
            int height = arr[left] > arr[right] ? arr[right] : arr[left];
            max = Math.Max(max, (right - left) * height);
            _ = arr[left] < arr[right] ? left++ : right--;
        }

        return max;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Input: [1, 8, 6, 2, 5, 4, 8, 3, 7], Output: {MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 })}, Expected: 49" );
        Console.WriteLine($"Input: [1, 1], Output: {MaxArea(new[] { 1, 1 })}, Expected: 1" );
    }
}