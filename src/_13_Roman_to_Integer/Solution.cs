namespace _13_Roman_to_Integer;

public class Solution
{
    // I can be placed before V (5) and X (10) to make 4 and 9. 
    // X can be placed before L (50) and C (100) to make 40 and 90. 
    // C can be placed before D (500) and M (1000) to make 400 and 900.
    public int RomanToInt(string s)
    {
        var dict = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        if (s.Length == 1)
            return dict[s[0]];

        var result = dict[s[^1]];
        var prev = dict[s[^1]];
        for (var i = s.Length - 2; i >= 0; i--)
        {
            var current = dict[s[i]];
            if (current < prev)
            {
                result -= current;
            }
            else
            {
                result += current;
                prev = current;
            }
        }

        return result;
    }
}