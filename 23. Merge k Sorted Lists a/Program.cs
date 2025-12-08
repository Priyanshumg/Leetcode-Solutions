namespace _23._Merge_k_Sorted_Lists_a;

class Program
{
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

    public static ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
            return null;
        return divide(lists, 0, lists.Length - 1);
    }

    public static ListNode divide(ListNode[] lst, int left, int right)
    {
        if (left == right)
            return lst[left];
        int mid = left + (right - left) / 2;
        ListNode leftNode = divide(lst, left, mid);
        ListNode rightNode = divide(lst, mid + 1, right);
        return merge(leftNode, rightNode);
    }

    public static ListNode merge(ListNode l1, ListNode l2)
    {
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;

        if (l1.val < l2.val)
        {
            l1.next = merge(l1.next, l2);
            return l1;
        }

        l2.next = merge(l1, l2.next);
        return l2;
    }

    static void Main(string[] args)
    {
        ListNode[] lists =
        [
            BuildList([1, 4, 5]),
            BuildList([1, 3, 4]),
            BuildList([2, 6]),
            BuildList([7, 8])
        ];
        var result = MergeKLists(lists);
        PrintList(result);
    }

    private static ListNode BuildList(int[] values)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        foreach (int val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }

        return dummy.next;
    }

    private static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val);
            if (head.next != null)
                Console.Write(" -> ");
            head = head.next;
        }
        Console.WriteLine();
    }

}