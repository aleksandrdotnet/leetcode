using Microsoft.EntityFrameworkCore;

namespace _1757_Recyclable_and_Low_Fat_Products;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
select
    ProductId
from
    Products
where 
    LowFats = 'Y' AND Recyclable = 'Y'")
            .ToList();

        var expected = new List<Result>
        {
            new() { ProductId = 1 },
            new() { ProductId = 3 }
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result,
                r => r.ProductId == exp.ProductId);
    }

    public class Result
    {
        public int ProductId { get; set; }
    }
}