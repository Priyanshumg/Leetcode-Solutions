namespace Debug_Console_Application;

class Program
{
    public static double findMedianofTwoSortedArrays(int[] arr1, int[] arr2)
    {
        // Below is Divide and Conquerer
        // Odd Case - min(r1, r2)
        // Even Case - max(l1, l2) + min(r1,r2)

        int length1 = arr1.Length, length2 = arr2.Length;
        if (length1 > length2) return findMedianofTwoSortedArrays(arr2, arr1);

        int start = 0, end = length1;

        while (start <= end)
        {
            int mid1 = (start + end) / 2;
            int mid2 = (length1 + length2 + 1) / 2 - mid1;
            
            int l1 = (mid1 == 0 ?  int.MinValue : arr1[mid1 - 1]);
            int r1 = (mid1 == length1 ? int.MaxValue : arr1[mid1]);

            int l2 = (mid2 == 0 ? int.MinValue : arr2[mid2 - 1]);
            int r2 = (mid2 == length2 ? int.MaxValue : arr2[mid2]);

            if (l1 < r2 && l2 <= r1)
            {
                if ((length1 + length2) % 2 == 0) return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
                else return Math.Max(l1, l2);
            }

            if (l1 > r2) end = mid1 - 1;
            else start = mid1 + 1;
        }

        return 0;
    }

    static void Main(string[] args)
    {
        int[] num1 = new[] { 1, 2 };
        int[] num2 = new[] { 3, 4 };
        Console.WriteLine(findMedianofTwoSortedArrays(num1, num2));
    }
} 