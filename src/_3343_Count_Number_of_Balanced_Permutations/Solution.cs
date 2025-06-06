namespace _3343_Count_Number_of_Balanced_Permutations;

public class Solution
{
    public int CountBalancedPermutations(string num)
    {
        var count = num.Length;
        var dict = new Dictionary<int, int>();

        foreach (var c in num) dict[c - 48] = dict.GetValueOrDefault(c - 48, 0) + 1;

        var result = dict.Sum(x => x.Key * x.Value);
        if (result % 2 != 0)
            return 0;

        return CountCombinations(result / 2, dict);
    }

    private static int CountCombinations(int target, Dictionary<int, int> digits)
    {
        var digitList = new List<int>(digits.Keys);
        var memo = new Dictionary<string, int>();
        return Count(target, 0, digitList, digits, memo) - digits.Sum(x => x.Value - 1);
    }

    private static int Count(int remaining, int index, List<int> digitList, Dictionary<int, int> limits,
        Dictionary<string, int> memo)
    {
        if (remaining == 0) return 1;
        if (remaining < 0 || index == digitList.Count) return 0;

        var key = $"{remaining}-{index}";
        if (memo.ContainsKey(key)) return memo[key];

        var digit = digitList[index];
        var maxCount = limits[digit];
        var total = 0;

        for (var count = 0; count <= maxCount; count++)
        {
            var sum = digit * count;
            if (sum > remaining) break;
            total += Count(remaining - sum, index + 1, digitList, limits, memo);
        }

        memo[key] = total;
        return total;
    }
}