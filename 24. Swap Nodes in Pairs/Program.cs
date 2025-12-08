namespace _24._Swap_Nodes_in_Pairs;

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

    public static ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        ListNode dummyNode = new ListNode(0, head);
        ListNode ptrNode = dummyNode;

        while (ptrNode.next != null && ptrNode.next.next != null)
        {
            ListNode first = ptrNode.next;
            ListNode second = first.next;

            first.next = second.next;
            second.next = first;
            ptrNode.next = second;

            ptrNode = first;
        }

        return dummyNode.next;
    }

    static void Main(string[] args)
    {
        TestSwapPairs();
    }
    
    public static void TestSwapPairs()
    {
        int[][] testCases =
        {
            new int[] {},                     // empty list
            new int[] {1},                   // single node
            new int[] {1,2},                 // single pair
            new int[] {1,2,3},               // odd length
            new int[] {1,2,3,4},             // even length
            new int[] {1,1,1,1},             // duplicates
            new int[] {5,10,15,20,25,30}     // long list
        };

        Console.WriteLine("==== Swap Nodes In Pairs Test ====\n");

        foreach (var test in testCases)
        {
            Console.Write("Input:    ");
            var input = BuildList(test);
            PrintList(input);

            var result = SwapPairs(input);

            Console.Write("Output:   ");
            PrintList(result);
            Console.WriteLine("------------------------------");
        }
    }
    
    public static ListNode BuildList(int[] values)
    {
        if (values.Length == 0) return null;

        ListNode head = new ListNode(values[0]);
        ListNode current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }
    
    public static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + (head.next != null ? " -> " : ""));
            head = head.next;
        }
        Console.WriteLine();
    }


}