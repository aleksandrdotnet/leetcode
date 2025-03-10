namespace _412_Fizz_Buzz;

public class Solution
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

    public static ListNode? Run(ListNode? input)
    {
        var middle = input;
        var start = input;
        
        while(start?.next != null)
        {
            middle = middle?.next;
            start = start.next.next;
        }
        
        return middle;
    }
}