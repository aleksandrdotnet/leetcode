namespace _2_Add_Two_Numbers;

public class Test
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new Solution.ListNode(2,
                new Solution.ListNode(4,
                    new Solution.ListNode(3))),

            new Solution.ListNode(5,
                new Solution.ListNode(6,
                    new Solution.ListNode(4))),
            
            new Solution.ListNode(7,
                new Solution.ListNode(0,
                    new Solution.ListNode(8)))
        ];
        
        yield return
        [
            new Solution.ListNode(),

            new Solution.ListNode(),
            
            new Solution.ListNode()
        ];

        yield return
        [
            new Solution.ListNode(9,
                new Solution.ListNode(9,
                    new Solution.ListNode(9,
                        new Solution.ListNode(9,
                            new Solution.ListNode(9,
                                new Solution.ListNode(9,
                                    new Solution.ListNode(9)
                                )))))),

            new Solution.ListNode(9,
                new Solution.ListNode(9,
                    new Solution.ListNode(9,
                        new Solution.ListNode(9
                        )))),

            new Solution.ListNode(8,
                new Solution.ListNode(9,
                    new Solution.ListNode(9,
                        new Solution.ListNode(9,
                            new Solution.ListNode(0,
                                new Solution.ListNode(0,
                                    new Solution.ListNode(0,
                                        new Solution.ListNode(1)
                                        )))))))
        ];
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Run(Solution.ListNode l1, Solution.ListNode l2, Solution.ListNode expceted)
    {
        var result = new Solution().AddTwoNumbers(l1, l2);

        var check = expceted;
        while (check != null)
        {
            Assert.Equal(check.val, result.val);
            
            check = check.next;
        }
    }
}