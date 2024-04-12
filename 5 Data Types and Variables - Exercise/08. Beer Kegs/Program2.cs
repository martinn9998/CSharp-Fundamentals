namespace BeerKegs
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var maxName = string.Empty;
            double maxNum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var kegModel = Console.ReadLine();
                var radiusOfKeg = double.Parse(Console.ReadLine());
                var heightOfKeg = double.Parse(Console.ReadLine());
                var calc = Math.PI * Math.Pow(radiusOfKeg, 2) * heightOfKeg;
                if (calc > maxNum)
                {
                    maxNum = calc;
                    maxName = kegModel;
                }
            }
            Console.WriteLine(maxName);
        }
    }
}