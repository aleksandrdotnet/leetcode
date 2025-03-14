namespace _1342_Number_Of_Steps_To_Reduce_A_Number_To_Zero;

public class Solution
{
    public static int Run(int input)
    {
        var result = 0;
        while (input != 0)
        {
            if (input % 2 == 0)
                input /= 2;
            else
                input--;

            result++;
        }

        return result;
    }
}