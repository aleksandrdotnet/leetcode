namespace _1346_Check_If_N_and_Its_Double_Exist;

public class Test
{
    [Theory]
    [InlineData(new[] { 10, 2, 5, 3 }, true)]
    [InlineData(new[] { 3, 1, 7, 11 }, false)]
    public void Run(int[] arr, bool expected)
    {
        var result = new Solution().CheckIfExist(arr);

        Assert.Equal(expected, result);
    }
}