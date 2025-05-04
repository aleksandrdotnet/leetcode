namespace _1128_Number_of_Equivalent_Domino_Pairs;

public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var dict = new Dictionary<int, int>();

        foreach (var domino in dominoes)
        {
            var key = domino[0] > domino[1] ? domino[0] * 10 + domino[1] : domino[1] * 10 + domino[0];
            dict[key] = dict.GetValueOrDefault(key, 0) + 1;
        }

        return dict
            .Where(x => x.Value > 1)
            .Sum(x => x.Value * (x.Value - 1) / 2);
    }
}