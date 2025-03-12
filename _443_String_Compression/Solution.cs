namespace _443_String_Compression;

public class Solution
{
    public static int Run(char[] input)
    {
        var begin = 0;
        var count = 0;

        while (begin < input.Length)
        {
            var group = 1;

            while (begin + group < input.Length && input[begin + group] == input[begin])
                group++;

            input[count++] = input[begin];
            begin += group;

            if (group > 1)
                foreach (var ch in group.ToString())
                    input[count++] = ch;
        }

        return count;
    }
}