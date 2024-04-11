namespace ConvertMetersToKilometers
{
    class Program
    {
        public static void Main()
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0m;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}