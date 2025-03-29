namespace _28_Find_the_Index_of_the_First_Occurrence_in_a_String;

public class Test
{
    [Theory]
    [InlineData("sadbutsad", "sad" , 0)]
    [InlineData("leetcode", "leeto" , -1)]
    [InlineData("aaaa", "aaa" , 0)]
    public void Run(string haystack, string needle, int expected)
    {
        var result = new Solution().StrStr(haystack, needle);
        Assert.Equal(expected, result);
    }
}