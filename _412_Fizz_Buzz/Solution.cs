namespace _412_Fizz_Buzz;

public class Solution
{
    public static IList<string> Run(int input)
    {
        var result = new List<string>();

        for (var i = 1; i <= input; i++)
        {
            if (i == 1)
                result.Add((i).ToString());
            else if (i % 5 == 0 && i % 3 == 0)
                result.Add("FizzBuzz");
            else if (i % 5 == 0)
                result.Add("Buzz");
            else if (i % 3 == 0)
                result.Add("Fizz");
            else
                result.Add((i).ToString());
        }

        return result;
    }
}