namespace TriplesOfLatinLetters
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (char x1 = 'a'; x1 < 'a' + n; x1++)
            {
                for (char x2 = 'a'; x2 < 'a' + n; x2++)
                {
                    for (char x3 = 'a'; x3 < 'a' + n; x3++)
                    {
                        Console.WriteLine($"{x1}{x2}{x3}");
                    }
                }
            }
        }
    }
}