namespace _2_Add_Two_Numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var leftNode = l1;
        long left = 0;
        long c = 1;
        while (leftNode != null)
        {
            left += leftNode.val * c;
            c *= 10;

            leftNode = leftNode.next;
        }

        var rightNode = l2;
        long right = 0;
        long d = 1;
        while (rightNode != null)
        {
            right += rightNode.val * d;
            d *= 10;
            rightNode = rightNode.next;
        }

        var sum = left + right;

        var result = new ListNode();
        var tmp = result;
        while (sum > 0)
        {
            var value = sum % 10;
            sum /= 10;

            tmp.val = (int)value;
            if (sum > 0)
            {
                tmp.next = new ListNode();
                tmp = tmp.next;
            }
        }

        return result;
    }
}

public class Solution2
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var result = new ListNode();
        var tmp = result;
        var c = 0;
        while (l1 != null || l2 != null || c != 0)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + c;
            c = sum / 10;

            if (sum > 9)
                sum %= 10;

            tmp.next = new ListNode(sum);
            tmp = tmp.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return result.next;
    }
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