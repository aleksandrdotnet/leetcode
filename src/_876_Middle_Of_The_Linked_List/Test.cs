namespace _876_Middle_Of_The_Linked_List;

public class Test
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new Solution.ListNode(1,
                new Solution.ListNode(2,
                    new Solution.ListNode(3,
                        new Solution.ListNode(4,
                            new Solution.ListNode(5))))),

            new Solution.ListNode(3,
                new Solution.ListNode(4,
                    new Solution.ListNode(5)))
        ];
        yield return
        [
            new Solution.ListNode(1,
                new Solution.ListNode(2,
                    new Solution.ListNode(3,
                        new Solution.ListNode(4,
                            new Solution.ListNode(5,
                                new Solution.ListNode(6)))))),

            new Solution.ListNode(4,
                new Solution.ListNode(5,
                    new Solution.ListNode(6)))
        ];
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Run(Solution.ListNode input, Solution.ListNode output)
    {
        var result = Solution.Run(input);

        Assert.Equivalent(output, result);
    }
}