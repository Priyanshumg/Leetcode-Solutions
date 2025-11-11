namespace _21._Merge_Two_Sorted_Lists;
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class LinkedListMerger
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }

        if (l1 == null)
            return l2;

        return l1;
    }
}
public static class MergeTwoListsTest
{
    public static void RunAllTests()
    {
        var merger = new LinkedListMerger();

        RunTest(merger,
            new int[] { 1, 3, 5 },
            new int[] { 2, 4, 6 },
            "Test Case 1: Equal Length Lists");

        RunTest(merger,
            new int[] { 1, 2, 3 },
            new int[] { },
            "Test Case 2: Second List Empty");

        RunTest(merger,
            new int[] { },
            new int[] { },
            "Test Case 3: Both Lists Empty");

        RunTest(merger,
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 2, 4 },
            "Test Case 4: Unequal Length Lists");

        RunTest(merger,
            new int[] { 1, 3, 5 },
            new int[] { 1, 3, 4 },
            "Test Case 5: Lists with Duplicates");
    }

    private static void RunTest(LinkedListMerger merger, int[] arr1, int[] arr2, string testName)
    {
        Console.WriteLine($"\n=== {testName} ===");

        var l1 = BuildList(arr1);
        var l2 = BuildList(arr2);
        var result = merger.MergeTwoLists(l1, l2);

        Console.WriteLine("List 1: " + (arr1.Length == 0 ? "Empty" : string.Join(" -> ", arr1)));
        Console.WriteLine("List 2: " + (arr2.Length == 0 ? "Empty" : string.Join(" -> ", arr2)));
        Console.Write("Merged: ");
        PrintList(result);

        Console.WriteLine("----------------------------");
    }

    private static ListNode BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        var head = new ListNode(values[0]);
        var current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    private static void PrintList(ListNode head)
    {
        if (head == null)
        {
            Console.WriteLine("Empty");
            return;
        }

        var current = head;
        while (current != null)
        {
            Console.Write(current.val);
            if (current.next != null)
                Console.Write(" -> ");
            current = current.next;
        }
        Console.WriteLine();
    }
}


