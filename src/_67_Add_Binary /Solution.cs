using System.Text;

namespace _67_Add_Binary;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var i = a.Length - 1;
        var j = b.Length - 1;
        var sb = new StringBuilder();
        var c = 0;

        while (i >= 0 || j >= 0 || c > 0)
        {
            var sum = c;
            if (i >= 0)
            {
                sum += a[i] == '1' ? 1 : 0;
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] == '1' ? 1 : 0;
                j--;
            }

            c = sum / 2;
            sb.Insert(0, sum % 2);
        }

        return sb.ToString();
    }
}