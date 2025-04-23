namespace _66_Plus_One;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var result = digits.Aggregate(0, (acc, digit) => acc * 10 + digit) + 1;

        var list = new List<int>();
        while (result != 0)
        {
            list.Add(result % 10);

            result /= 10;
        }

        list.Reverse();
        return list.ToArray();
    }
}

public class Solution2
{
    public int[] PlusOne(int[] digits)
    {
        var item = digits[^1] + 1;
        var c = item / 10;
        digits[^1] = item % 10;

        for (var i = digits.Length - 2; i >= 0; i--)
        {
            item = digits[i] + c;

            c = item / 10;

            digits[i] = item % 10;
        }

        if (c == 1)
        {
            var arr = new int[digits.Length + 1];
            arr[0] = c;

            Array.Copy(digits, 0, arr, 1, digits.Length);

            return arr;
        }

        return digits;
    }
}