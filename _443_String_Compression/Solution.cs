namespace _443_String_Compression;

public class Solution
{
    public static int Run(char[] input)
    {
        var i = 0;
        var count = 0;
        while (i < input.Length)
        {
            var group = 0;
            count++;
            var item = input[i++];

            while (i + group < input.Length && input[i + group] == item) group++;

            if (group > 1)
            {
                var str = group.ToString();
                for (var k = 0; k < str.Length; k++)
                    input[i + k] = str[k];

                i += str.Length - 1;
                count += str.Length - 1;
            }
        }

        return count;
    }
}