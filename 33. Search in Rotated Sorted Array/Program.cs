namespace _33._Search_in_Rotated_Sorted_Array;

class Program
{
    public static int Search(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
                return mid;
            
            // Search in LHS Sorted Array
            if (nums[start] < nums[mid])
            {
                if (target >= nums[start] && target < nums[end])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            else
            {
                if (target > nums[mid] && target <= nums[end])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
        }

        return -1;
    }
    
    public static void RunRotatedSearchTests()
    {
        int[][] testArrays = {
            new int[] {4,5,6,7,0,1,2},
            new int[] {6,7,1,2,3,4,5},
            new int[] {1},
            new int[] {1,3},
            new int[] {3,1},
            new int[] {1,2,3,4,5,6,7},
            new int[] {7,8,1,2,3,4,5,6},
            new int[] {30,40,50,10,20}
        };

        int[] testTargets = {0, 3, 1, 3, 3, 6, 8, 10};
        int[] expectedOutputs = {4, 4, 0, 1, 0, 5, 1, 3};

        Console.WriteLine("Running Test Cases:\n");

        for (int i = 0; i < testArrays.Length; i++)
        {
            int result = Search(testArrays[i], testTargets[i]);
            Console.WriteLine($"Test {i+1}: Target {testTargets[i],-3} → Output: {result,-3} | Expected: {expectedOutputs[i]} {(result == expectedOutputs[i] ? "✔" : "❌")}");
        }
    }

    static void Main(string[] args)
    {
        RunRotatedSearchTests();
    }
}