namespace CharsToString
{
    class Program
    {
        public static void Main()
        {
            var ch1 = char.Parse(Console.ReadLine());
            var ch2 = char.Parse(Console.ReadLine());
            var ch3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{ch1}{ch2}{ch3}");
        }
    }
}