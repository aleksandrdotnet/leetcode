namespace _790_Domino_and_Tromino_Tiling;

public class Solution
{
    public int NumTilings(int n)
    {
        return n switch
        {
            1 => 1,
            2 => 2,
            3 => 5,
            _ => (NumTilings(n - 1) * 2 % 1_000_000_007 + NumTilings(n - 3) % 1_000_000_007) % 1_000_000_007
        };
    }
}

public class Solution2
{
    public int NumTilings(int n)
    {
        var result = new int[n < 4 ? 4 : n + 1];
        result[0] = 0;
        result[1] = 1;
        result[2] = 2;
        result[3] = 5;

        if (n < 4)
            return result[n];

        const int mod = 1_000_000_007;
        for (var i = 4; i <= n; i++)
            result[i] = (2 * result[i - 1] % mod + result[i - 3] % mod) % mod;

        return result[n];
    }
}