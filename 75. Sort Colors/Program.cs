namespace _75._Sort_Colors;

class Program
{
    private static void SortColorsv1(int[] nums)
    {
        for (int i = 0; i <nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[j] < nums[i])
                    (nums[j], nums[i]) = (nums[i], nums[j]);
    }

    private static void SortColorsv2(int[] nums)
    {
        int low = 0, mid = 0, high = nums.Length - 1;
        while (mid <= high)
        {
            switch (nums[mid])
            {
                case 0:
                    (nums[low], nums[mid]) = (nums[mid], nums[low]);
                    low++; mid++; break;
                case 1:
                    mid++; break;
                case 2:
                    (nums[mid], nums[high]) = (nums[high], nums[mid]);
                    high--; break;
            }
        }
    }
    
    
    private static void Main(string[] args)
    {
        int[] nums = [2, 0, 2, 1, 1, 0];
        SortColorsv2(nums);
        foreach (var element in nums)
            Console.Write(element +  ", ");
    }
}