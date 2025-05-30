namespace _2094_Finding_3_Digit_Even_Numbers;

public class Solution
{
    public int[] FindEvenNumbers(int[] digits)
    {
        var hashSet = new HashSet<int>();

        for (var i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
                continue;

            for (var j = 0; j < digits.Length; j++)
            {
                if (i == j)
                    continue;

                for (var k = 0; k < digits.Length; k++)
                {
                    if (j == k || i == k || digits[k] % 2 == 1)
                        continue;

                    hashSet.Add(digits[i] * 100 + digits[j] * 10 + digits[k]);
                }
            }
        }

        return hashSet.OrderBy(x => x).ToArray();
    }
}

public class Solution2
{
    public int[] FindEvenNumbers(int[] digits)
    {
        var result = new List<int>();
        var dict = new int[10];
        foreach (var num in digits)
            dict[num]++;

        var n = new int[10];
        for (var num = 100; num < 1000; num += 2)
        {
            var ones = num % 10;
            var tens = num / 10 % 10;
            var hund = num / 100;

            n[ones]++;
            n[tens]++;
            n[hund]++;

            if (n[ones] <= dict[ones] && n[tens] <= dict[tens] && n[hund] <= dict[hund]) result.Add(num);

            n[ones] = 0;
            n[tens] = 0;
            n[hund] = 0;
        }

        return result.ToArray();
    }
}