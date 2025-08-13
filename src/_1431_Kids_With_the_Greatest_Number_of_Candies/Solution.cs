namespace _1431_Kids_With_the_Greatest_Number_of_Candies;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies[0];

        var result = new bool[candies.Length];
        foreach (var c in candies)
            max = Math.Max(max, c);

        for (var i = 0; i < candies.Length; i++)
            if (candies[i] + extraCandies >= max)
                result[i] = true;

        return result;
    }
}