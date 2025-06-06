using Microsoft.EntityFrameworkCore;

namespace _1251_Average_Selling_Price;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>(
                $@"
select
    p.product_id [ProductId],
    case
        when sum(us.units) is null then 0
        else round(sum(p.price * us.units) * 1.0 / sum(us.units), 2)
        end
        [AveragePrice]
from
    Prices p
        left join UnitsSold us on p.product_id = us.product_id
        and us.purchase_date >= p.start_date and us.purchase_date <= p.end_date
group by
    p.product_id")
            .ToList();

        var expected = new List<Result>
        {
            new(1, 6.96),
            new(2, 16.96)
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result, r => r.ProductId == exp.ProductId
                                         && r.AveragePrice == exp.AveragePrice);
    }

    public class Result
    {
        public Result(int productId, double averagePrice)
        {
            ProductId = productId;
            AveragePrice = averagePrice;
        }

        public int ProductId { get; set; }
        public double AveragePrice { get; set; }
    }
}