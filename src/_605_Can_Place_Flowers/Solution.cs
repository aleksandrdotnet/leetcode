namespace _605_Can_Place_Flowers;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if(n == 0)
            return true;
        
        if(n > flowerbed.Length/2 + flowerbed.Length % 2)
            return false;
        
        if (flowerbed.Length == 1)
            return flowerbed[0] == 0;
        
        if (flowerbed.Length == 2)
            return flowerbed[0] == flowerbed[1] && flowerbed[0] == 0;

        for (var i = 2; i < flowerbed.Length; i++)
        {
            if(i == 2 && flowerbed[i - 2] == 0 && flowerbed[i-1] == 0)
            {
                flowerbed[i - 2] = 1;
                n--;
            }
            if(i == flowerbed.Length - 1 && flowerbed[i] == 0 && flowerbed[i-1] == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
            else if (flowerbed[i - 2] == 0 && flowerbed[i-1] == 0 && flowerbed[i] == 0)
            {
                flowerbed[i-1] = 1;
                n--;
            }

            if(n <= 0)
                return true;
        }
        
        return false;
    }
}