namespace LowerOrUpper
{
    class Program
    {
        public static void Main()
        {
            char character = char.Parse(Console.ReadLine());
            if (character >= 65 && character <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (character >= 97 && character <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}