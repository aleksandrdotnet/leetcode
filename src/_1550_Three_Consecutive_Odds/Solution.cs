namespace _1550_Three_Consecutive_Odds;

public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        for (var i = 2; i < arr.Length; i++)
        {
            var first = arr[i - 2];
            var second = arr[i - 1];
            var third = arr[i];

            if (first % 2 == 1 && second % 2 == 1 && third % 2 == 1)
                return true;
        }

        return false;
    }
}