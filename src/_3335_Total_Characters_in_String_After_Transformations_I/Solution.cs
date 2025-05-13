namespace _3335_Total_Characters_in_String_After_Transformations_I;

public class Solution
{
    public int LengthAfterTransformations(string s, int t)
    {
        var MOD = 1_000_000_007;
        
        var chars = new int [26];
        foreach (var letter in s)
            chars[letter - 'a']++;

        while (t-- > 0)
        {
            var newChars = new int [26];
            for (int i = 0; i < 25; i++)
            {
                newChars[i + 1] = chars[i];
            }
            
            newChars[0] = chars[25];
            newChars[1] = (newChars[1] + chars[25]) % MOD;
            
            chars = newChars;
        }
        
        return chars.Aggregate(0, (current, n) => (current + n) % MOD);
    }
}