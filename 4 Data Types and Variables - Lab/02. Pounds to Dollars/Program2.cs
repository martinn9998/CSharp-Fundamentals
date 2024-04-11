namespace PoundToDollars
{
    class Program
    {
        public static void Main()
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollars = pound * 1.31m;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}