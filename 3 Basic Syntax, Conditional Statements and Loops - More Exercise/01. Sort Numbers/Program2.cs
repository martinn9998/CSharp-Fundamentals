namespace SortNumbers
{
    class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var max = Math.Max(Math.Max(a, b), c);
            var min = Math.Min(Math.Min(a, b), c);
            var middle = (a + b + c) - (max + min);
            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
        }
    }
}
