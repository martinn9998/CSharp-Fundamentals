using System.Numerics;

namespace Smowballs
{
    class Program
    {
        public static void Main()
        {
            var numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int biggestSnowballSnow = 0;
            int biggestSnowballTime = 0;
            int biggestSnowballQuality = 0;
            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuantity = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuantity);
                if (snowballValue > maxValue)
                {
                    biggestSnowballSnow = snowballSnow;
                    biggestSnowballTime = snowballTime;
                    biggestSnowballQuality = snowballQuantity;
                    maxValue = snowballValue;
                }
            }
            Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {maxValue} ({biggestSnowballQuality})");
        }
    }
}