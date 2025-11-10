namespace c;

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

class Program
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode slowPtr = dummy, fastPtr = dummy;
        for (int i = 0; i < n; i++)
            fastPtr = fastPtr.next;

        while (fastPtr?.next != null)
        {
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next;
        }
        slowPtr.next = slowPtr.next.next;
        return dummy.next;
    }
    
    static void Main(string[] args)
    {
        TestRunner.RunTests();
    }
}

    public class TestRunner
    {
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

        public static List<int> ToList(ListNode head)
        {
            List<int> result = new List<int>();
            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }
            return result;
        }

        public static void RunTests()
        {
            var testCases = new List<(int[] input, int n, int[] expected)>
            {
                (new int[] {1,2,3,4,5}, 2, new int[] {1,2,3,5}),
                (new int[] {1}, 1, new int[] {}),
                (new int[] {1,2}, 1, new int[] {1}),
                (new int[] {1,2}, 2, new int[] {2}),
                (new int[] {10,20,30,40,50,60}, 6, new int[] {20,30,40,50,60})
            };

            int passed = 0;
            for (int i = 0; i < testCases.Count; i++)
            {
                var (input, n, expected) = testCases[i];
                ListNode head = BuildList(input);
                var result = Program.RemoveNthFromEnd(head, n);
                var resultList = ToList(result);

                bool isEqual = expected.Length == resultList.Count;
                if (isEqual)
                {
                    for (int j = 0; j < expected.Length; j++)
                        if (expected[j] != resultList[j])
                            isEqual = false;
                }

                if (isEqual)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"✅ Test {i + 1} Passed");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"❌ Test {i + 1} Failed");
                    Console.WriteLine($"Input: [{string.Join(",", input)}], n={n}");
                    Console.WriteLine($"Expected: [{string.Join(",", expected)}]");
                    Console.WriteLine($"Got: [{string.Join(",", resultList)}]");
                }
                Console.ResetColor();
            }

            Console.WriteLine("\nAll tests completed.");
        }
    }
