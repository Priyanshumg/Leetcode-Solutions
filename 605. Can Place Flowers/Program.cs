namespace _605._Can_Place_Flowers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1));
        Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2));
        Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 1 }, 2));
        Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0, 1, 0, 1 }, 2));
    }    
    public static bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (int i = 0; i < flowerbed.Length; i++)
        {
            bool emptyLeft = (i == 0) || (flowerbed[i - 1] == 0);
            bool emptyRight = (i == flowerbed.Length - 1) ||  (flowerbed[i + 1] == 0);
            if (flowerbed[i] == 0 && emptyLeft && emptyRight)
            {
                flowerbed[i] = 1;
                n--;
            }
        }
        return n <= 0;
    }
}