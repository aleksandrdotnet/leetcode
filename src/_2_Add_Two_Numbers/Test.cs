namespace _2_Add_Two_Numbers;

public class Test
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new ListNode(2,
                new ListNode(4,
                    new ListNode(3))),

            new ListNode(5,
                new ListNode(6,
                    new ListNode(4))),

            new ListNode(7,
                new ListNode(0,
                    new ListNode(8)))
        ];

        yield return
        [
            new ListNode(),

            new ListNode(),

            new ListNode()
        ];

        yield return
        [
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9,
                                    new ListNode(9)
                                )))))),

            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9
                        )))),

            new ListNode(8,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(0,
                                new ListNode(0,
                                    new ListNode(0,
                                        new ListNode(1)
                                    )))))))
        ];


        yield return
        [
            new ListNode(9),

            new ListNode(1,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9,
                                    new ListNode(9,
                                        new ListNode(9,
                                            new ListNode(9,
                                                new ListNode(9)))
                                    ))))))),

            new ListNode(0,
                new ListNode(0,
                    new ListNode(0,
                        new ListNode(0,
                            new ListNode(0,
                                new ListNode(0,
                                    new ListNode(0,
                                        new ListNode(0,
                                            new ListNode(0,
                                                new ListNode(0,
                                                    new ListNode(1)
                                                ))))))))))
        ];
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Run(ListNode l1, ListNode l2, ListNode expceted)
    {
        var result = new Solution().AddTwoNumbers(l1, l2);

        var check = expceted;
        while (check != null)
        {
            Assert.Equal(check.val, result.val);

            check = check.next;
            result = result.next;
        }
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Run2(ListNode l1, ListNode l2, ListNode expceted)
    {
        var result = new Solution2().AddTwoNumbers(l1, l2);

        var check = expceted;
        while (check != null)
        {
            Assert.Equal(check.val, result.val);

            check = check.next;
            result = result.next;
        }
    }
}