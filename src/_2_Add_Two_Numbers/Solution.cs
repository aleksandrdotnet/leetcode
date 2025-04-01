namespace _2_Add_Two_Numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var l1ref = l1;
        var l2ref = l2;
        var result = new ListNode((l1?.val ?? 0) + (l2?.val ?? 0));
        var r = result;
        var c = 0;
        while (l1ref?.next != null || l2ref?.next != null)
        {
            r.next = new ListNode();
            var val = (l1ref?.val ?? 0) + (l2ref?.val ?? 0);

            if (val > 9)
            {
                r.val = val % 10 + c;
                r.next = new ListNode();
                c = 1;
            }
            else
            {
                r.val = val + c;
                c = 0;
            }

            if (l1ref?.next != null || l2ref?.next != null)
            {
                if (l2ref?.next != null)
                    l2ref = l2ref.next;

                if (l1ref?.next != null)
                    l1ref = l1ref.next;

                r = r.next;
            }
        }

        return result;
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