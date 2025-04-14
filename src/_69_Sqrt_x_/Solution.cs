namespace _69_Sqrt_x_;

public class Solution
{
    public int MySqrt(int x)
    {
        switch (x)
        {
            case 0:
                return x;
            case < 4:
                return 1;
            case < 9:
                return 2;
        }

        var d = 1;
        var s = x;
        while (s / 10 > 10)
        {d++; s /= 10; }

        var mn = Math.Max(x >> d, 0);
        while (mn > x/mn)
            mn >>= 1;

        while((mn+1) <= x/(mn+1))
            mn += 1;

        return mn;
    }
}

public class Solution2
{
    public int MySqrt(int x)
    {
        if (x < 2) return x;

        int left = 1, right = x / 2, result = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid; // чтобы не было переполнения

            if (square == x)
                return mid;
            else if (square < x)
            {
                result = mid; // сохраняем последний успешный
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }

}