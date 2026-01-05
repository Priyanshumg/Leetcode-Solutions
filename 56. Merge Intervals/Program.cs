namespace _56._Merge_Intervals;

class Program
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length < 1)
            return intervals;
        
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        result.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] last = result[^1];
            if (intervals[i][0] <= last[1])
                last[1] = Math.Max(last[1], intervals[i][1]);
            else
                result.Add(intervals[i]);
        }
        return result.ToArray();
    }
    static void Main()
    {
        var p = new Program();

        int[][] intervals = {
            new int[] {8,10},
            new int[] {1,3},
            new int[] {2,6}
        };

        var result = p.Merge(intervals);

        foreach (var i in result)
            Console.WriteLine($"[{i[0]}, {i[1]}]");
    }
}