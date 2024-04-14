namespace RoundingNumbers
{
    class Program
    {
        public static void Main()
        {
            double[] floatingNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            foreach (var floatingNumber in floatingNumbers)
            {
                int roundingNumbers = (int)Math.Round(floatingNumber,MidpointRounding.AwayFromZero);
                Console.WriteLine($"{floatingNumber} => {roundingNumbers}");
            }
        }
    }
}