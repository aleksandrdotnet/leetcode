namespace _876_Middle_Of_The_Linked_List;

public class Solution
{
    public static ListNode? Run(ListNode? input)
    {
        var middle = input;
        var start = input;

        while (start?.next != null)
        {
            middle = middle?.next;
            start = start.next.next;
        }

        return middle;
    }

    public class ListNode
    {
        public ListNode next;
        public int val;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}