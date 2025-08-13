namespace _11_Container_With_Most_Water;

public class Solution
{
    public int MaxArea(int[] height)
    {
        var result = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            var h = height[left] > height[right] ? height[right] : height[left];

            result = Math.Max(result, h * (right - left));
            
            _ = height[left] < height[right] ? left++: right--;
        }
        
        return result;
    }
}