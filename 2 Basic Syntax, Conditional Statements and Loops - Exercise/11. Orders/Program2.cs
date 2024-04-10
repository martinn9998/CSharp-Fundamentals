namespace Orders
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = double.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsulesCount = int.Parse(Console.ReadLine());
                var calc = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${calc:f2}");
                sum += calc;
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
