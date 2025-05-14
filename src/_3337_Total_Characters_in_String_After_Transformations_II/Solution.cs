namespace _3337_Total_Characters_in_String_After_Transformations_II;

public class Solution
{
    // Time Limit Exceeded
    public int LengthAfterTransformations(string s, int t, IList<int> nums)
    {
        const int mod = 1_000_000_007;
        
        var chars = new int[26];
        foreach (var c in s)
            chars[c - 'a']++;
        
        while (t-- > 0)
        {
            var newChars = new int[26];
            for (var i = 0; i < 26; i++)
            {
                if(chars[i] == 0) continue;
                
                for (var j = 0; j < nums[i]; j++)
                {
                    var index = (i + j + 1) % 26;
                    newChars[index] = (newChars[index] + chars[i]) % mod;
                }
            }
            
            Array.Copy(newChars, 0, chars, 0, chars.Length);
        }
        
        return chars.Aggregate(0, (current, n) => (current + n) % mod);
    }
}

public class Solution2
{
    private const int MOD = 1_000_000_007;

    public int LengthAfterTransformations(string s, int t, IList<int> nums)
    {
        var T = GetTransformationMatrix(nums);
        int[][] poweredT = MatrixPow(T, t);
        int[] count = new int[26];
        long[] lengths = new long[26];

        foreach (char c in s)
            count[c - 'a']++;

        for (int i = 0; i < 26; ++i)
        for (int j = 0; j < 26; ++j)
        {
            lengths[j] += (long)count[i] * poweredT[i][j];
            lengths[j] %= MOD;
        }

        return (int)(lengths.Sum() % MOD);
    }

    private int[][] GetTransformationMatrix(IList<int> nums)
    {
        var T = CreateMatrix(26, 26);
        for (int i = 0; i < nums.Count; ++i)
        for (int step = 1; step <= nums[i]; ++step)
            T[i][(i + step) % 26]++;
        return T;
    }

    private int[][] GetIdentityMatrix(int size)
    {
        int[][] I = CreateMatrix(size, size);
        for (int i = 0; i < size; ++i)
            I[i][i] = 1;
        return I;
    }

    private int[][] MatrixMult(int[][] A, int[][] B)
    {
        int size = A.Length;
        int[][] C = CreateMatrix(size, size);
        for (int i = 0; i < size; ++i)
        for (int j = 0; j < size; ++j)
        for (int k = 0; k < size; ++k)
            C[i][j] = (int)((C[i][j] + (long)A[i][k] * B[k][j]) % MOD);
        return C;
    }

    private int[][] MatrixPow(int[][] M, int n)
    {
        if (n == 0)
            return GetIdentityMatrix(M.Length);
        if (n % 2 == 1)
            return MatrixMult(M, MatrixPow(M, n - 1));
        return MatrixPow(MatrixMult(M, M), n / 2);
    }

    private int[][] CreateMatrix(int rows, int cols)
    {
        int[][] matrix = new int[rows][];
        for (int i = 0; i < rows; ++i)
            matrix[i] = new int[cols];
        return matrix;
    }
}