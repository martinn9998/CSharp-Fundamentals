namespace SumOfChars
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sum += character;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}