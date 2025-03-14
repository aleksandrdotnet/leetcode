namespace _383_Ransom_Note;

public class Solution
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var hs = new Dictionary<char, int>();
        foreach (var ch in magazine)
            if (!hs.TryAdd(ch, 1))
                hs[ch]++;

        foreach (var r in ransomNote)
        {
            if (!hs.TryGetValue(r, out var h) || h <= 0)
                return false;

            hs[r]--;
        }

        return true;
    }
}