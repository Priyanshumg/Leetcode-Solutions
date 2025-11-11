namespace _21._Merge_Two_Sorted_Lists;

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

    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null)
            return l2;
        
        if (l2 == null)
            return l1;
        
        if (l1.val < l2.val)
        {
            l1.next = MergeTwoLists(l1.next, l2);
            return l1;
        }

        l2.next = MergeTwoLists(l1, l2.next);
        return l2;
    }
    
    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode mergedHead = MergeTwoLists(l1, l2);

        Console.WriteLine("Merged Sorted Linked List:");
        PrintList(mergedHead);

        MergeTwoListsTest.RunAllTests();
    }
    
    public static void PrintList(ListNode head)
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