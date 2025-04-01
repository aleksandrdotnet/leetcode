namespace _2114_Maximum_Number_of_Words_Found_in_Sentences;

public class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        var max = 0;
        foreach (var item in sentences)
            max = Math.Max(max, item.Split(' ').Count());

        return max;
    }
}