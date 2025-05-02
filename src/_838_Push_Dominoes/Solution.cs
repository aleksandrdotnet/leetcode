using System.Text;

namespace _838_Push_Dominoes;

public class Solution
{
    public string PushDominoes(string dominoes)
    {
        var s = dominoes.ToCharArray();
        int L = -1, R = -1;

        for (var i = 0; i < s.Length; i++)
        {
            if (i == s.Length || s[i] == 'R')
            {
                if (L < R)
                {
                    while (R < i)
                    {
                        s[R++] = 'R';
                    }
                }

                R = i;
            }
            else if (s[i] == 'L')
            {
                if (R < L || (L == -1 && R == -1))
                {
                    if (L == -1 && R == -1) L = 0;
                    while (L < i)
                    {
                        s[L++] = 'L';
                    }
                }
                else
                {
                    int l = R + 1;
                    int r = i - 1;
                    while (l < r)
                    {
                        s[l++] = 'R';
                        s[r--] = 'L';
                    }
                }

                L = i;
            }
        }

        return new string(s);
    }
}