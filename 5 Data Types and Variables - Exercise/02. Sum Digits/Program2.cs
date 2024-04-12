namespace SumDigits
{
    class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;
            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}