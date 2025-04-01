using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace _941_Valid_Mountain_Array_Benchmark;

public class Solution
{
    [ParamsSource(nameof(TestArrays))] public int[] arr;

    public static IEnumerable<int[]> TestArrays()
    {
        return new[]
        {
            new[] { 2, 1 },
            new[] { 3, 5, 5 },
            new[] { 0, 3, 2, 1 },
            new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }
        };
    }

    [Benchmark]
    public bool ValidMountainArray()
    {
        return ValidMountainArrayMethod(arr);
    }

    [Benchmark]
    public bool ValidMountainArray2()
    {
        return ValidMountainArray2Method(arr);
    }

    public bool ValidMountainArrayMethod(int[] arr)
    {
        if (arr.Length < 3) return false;

        var peak = 0;
        for (var i = 1; i < arr.Length; i++)
            if (arr[i - 1] < arr[i])
                peak = i;
            else
                break;

        if (peak == 0 || peak == arr.Length - 1) return false;

        for (var j = peak + 1; j < arr.Length; j++)
            if (arr[j - 1] <= arr[j])
                return false;

        return true;
    }

    public bool ValidMountainArray2Method(int[] arr)
    {
        if (arr.Length < 3) return false;

        var left = 0;
        var right = arr.Length - 1;

        while (left < right && left + 1 < arr.Length && right - 1 > 0)
        {
            var change = false;

            if (arr[left] == arr[left + 1] || arr[right] == arr[right - 1])
                return false;

            if (arr[left] < arr[left + 1])
            {
                left++;
                change = true;
            }

            if (arr[right - 1] > arr[right])
            {
                right--;
                change = true;
            }

            if (!change)
                return false;
        }

        return left == right && left != 0 && right != arr.Length - 1;
    }
}

internal class Program
{
    private static void Main()
    {
        BenchmarkRunner.Run<Solution>();
    }
}