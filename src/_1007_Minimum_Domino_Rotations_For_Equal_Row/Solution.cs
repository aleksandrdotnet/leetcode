namespace _1007_Minimum_Domino_Rotations_For_Equal_Row;

public class Solution
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        var count = 0;
        var candidate = -1;

        foreach (var d in tops)
        {
            if (count == 0) candidate = d;

            count += d == candidate ? 1 : -1;
        }

        for (var i = 0; i < bottoms.Length; i++)
        {
            var d = bottoms[i];
            if (count == 0) candidate = d;

            if (tops[i] != candidate || bottoms[i] != candidate)
                count += d == candidate ? 1 : -1;
        }


        var topCount = tops.Count(d => d == candidate);
        var bottomCount = 0;
        var bottomCountMax = 0;
        for (var i = 0; i < bottoms.Length; i++)
        {
            if (tops[i] != candidate || bottoms[i] != candidate)
                if (bottoms[i] == candidate)
                    bottomCount++;

            if (bottoms[i] == candidate)
                bottomCountMax++;
        }

        if (topCount + bottomCount < tops.Length)
            return -1;

        if (topCount >= bottomCountMax)
            return tops.Length - topCount;

        return tops.Length - bottomCountMax;
    }
}

public class Solution2
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        var topCounter = new int[7];
        var bottomCounter = new int[7];
        var sameCounter = new int[7];

        for (var i = 0; i < tops.Length; i++)
        {
            topCounter[tops[i]]++;
            bottomCounter[bottoms[i]]++;
            if (tops[i] == bottoms[i]) sameCounter[tops[i]]++;
        }

        for (var i = 0; i < 7; i++)
            if (topCounter[i] + bottomCounter[i] - sameCounter[i] == tops.Length)
                return tops.Length - Math.Max(topCounter[i], bottomCounter[i]);

        return -1;
    }
}