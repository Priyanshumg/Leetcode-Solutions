namespace _2._Add_Two_Numbers____Recursion;

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
    
    private static void PrintList(ListNode node)
    {
        if (node == null)
        {
            Console.WriteLine("Empty list");
            return;
        }

        while (node != null)
        {
            Console.Write(node.val);
            if (node.next != null)
                Console.Write(" -> ");
            node = node.next;
        }

        Console.WriteLine();
    }
    
    private static void Main(string[] args)
    {
        var program = new Program();

        // Test Case 1: Basic addition (342 + 465 = 807)
        // Input: l1 = [2,4,3], l2 = [5,6,4]
        // Output: [7,0,8]
        Console.WriteLine("Test Case 1: 342 + 465 = 807");
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var result1 = program.AddTwoNumbers(l1, l2);
        PrintList(result1); // Expected: 7 -> 0 -> 8

        // Test Case 2: Addition with carry (9 + 9991 = 10000)
        // Input: l1 = [9], l2 = [1,9,9,9]
        // Output: [0,0,0,0,1]
        Console.WriteLine("\nTest Case 2: 9 + 9991 = 10000");
        var l3 = new ListNode(9);
        var l4 = new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9))));
        var result2 = program.AddTwoNumbers(l3, l4);
        PrintList(result2); // Expected: 0 -> 0 -> 0 -> 0 -> 1

        // Test Case 3: Both single digit (0 + 0 = 0)
        // Input: l1 = [0], l2 = [0]
        // Output: [0]
        Console.WriteLine("\nTest Case 3: 0 + 0 = 0");
        var l5 = new ListNode(0);
        var l6 = new ListNode(0);
        var result3 = program.AddTwoNumbers(l5, l6);
        PrintList(result3); // Expected: 0

        // Test Case 4: Different lengths (99 + 1 = 100)
        // Input: l1 = [9,9], l2 = [1]
        // Output: [0,0,1]
        Console.WriteLine("\nTest Case 4: 99 + 1 = 100");
        var l7 = new ListNode(9, new ListNode(9));
        var l8 = new ListNode(1);
        var result4 = program.AddTwoNumbers(l7, l8);
        PrintList(result4); // Expected: 0 -> 0 -> 1

        // Test Case 5: Large numbers with carry (999 + 999 = 1998)
        // Input: l1 = [9,9,9], l2 = [9,9,9]
        // Output: [8,9,9,1]
        Console.WriteLine("\nTest Case 5: 999 + 999 = 1998");
        var l9 = new ListNode(9, new ListNode(9, new ListNode(9)));
        var l10 = new ListNode(9, new ListNode(9, new ListNode(9)));
        var result5 = program.AddTwoNumbers(l9, l10);
        PrintList(result5); // Expected: 8 -> 9 -> 9 -> 1

        // Test Case 6: No carry (123 + 456 = 579)
        // Input: l1 = [3,2,1], l2 = [6,5,4]
        // Output: [9,7,5]
        Console.WriteLine("\nTest Case 6: 123 + 456 = 579");
        var l11 = new ListNode(3, new ListNode(2, new ListNode(1)));
        var l12 = new ListNode(6, new ListNode(5, new ListNode(4)));
        var result6 = program.AddTwoNumbers(l11, l12);
        PrintList(result6); // Expected: 9 -> 7 -> 5
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddTwoNumbers(l1, l2, 0);
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry)
    {
        if (l1 == null && l2 == null & carry == 0)
            return null;

        int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
        return new ListNode(sum % 10, AddTwoNumbers(l1?.next, l2?.next, sum / 10));
    }

}