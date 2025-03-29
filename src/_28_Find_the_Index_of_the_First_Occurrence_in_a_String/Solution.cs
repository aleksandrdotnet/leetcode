namespace _28_Find_the_Index_of_the_First_Occurrence_in_a_String;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        for (var i = 0; i < haystack.Length; i++)
        {
            var flag = false;
            for (var j = 0; j < needle.Length; j++)
            {
                if (i + j >= haystack.Length || haystack[i + j] != needle[j])
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
                return i;
        }

        return -1;
    }
}