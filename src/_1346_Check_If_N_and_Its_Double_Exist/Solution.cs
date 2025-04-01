namespace _1346_Check_If_N_and_Its_Double_Exist;

public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        for (var j = i + 1; j < arr.Length; j++)
            if (arr[i] == 2 * arr[j] || arr[i] == arr[j] / 2.0)
                return true;

        return false;
    }
}