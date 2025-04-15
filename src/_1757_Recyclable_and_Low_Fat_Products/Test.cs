using Microsoft.EntityFrameworkCore;

namespace _1757_Recyclable_and_Low_Fat_Products;

public class Test
{
    [Fact]
    public void CTE_Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
select
    product_id
from
    Products
where 
    low_fats = 'Y' AND recyclable = 'Y'")
            .ToList();

        var expected = new List<Result>
        {
            new() { product_id = 1 }
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result,
                r => r.product_id == exp.product_id);
    }

    public class Result
    {
        public int product_id { get; set; }
    }
}