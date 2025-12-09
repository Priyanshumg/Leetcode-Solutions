namespace _25._Reverse_Nodes_in_k_Group;

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

    public ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy, curr = head;
        int Length = 0;
        while (curr != null)
        {
            curr = curr.next;
            Length++;
        }

        while (Length >= k)
        {
            curr = prev.next;
            ListNode nxt = curr.next;
            for (int i = 1; i < k; i++)
            {
                curr.next = nxt.next;
                nxt.next = prev.next;
                prev.next = nxt;
                nxt = curr.next;
            }
            prev = curr;
            Length -= k;
        }
        return dummy.next;
    }
    static ListNode CreateList(int[] values)
    {
        ListNode dummy = new ListNode();
        ListNode curr = dummy;

        foreach (var v in values)
        {
            curr.next = new ListNode(v);
            curr = curr.next;
        }

        return dummy.next;
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        var program = new Program();

        ListNode head = CreateList(new int[] { 1, 2, 3, 4, 5 });
        int k = 2;

        var result = program.ReverseKGroup(head, k);

        PrintList(result);
    }

}