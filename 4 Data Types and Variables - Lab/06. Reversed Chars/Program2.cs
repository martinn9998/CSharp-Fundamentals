namespace ReversedChars
{
    class Program
    {
        public static void Main()
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());
            char[] arrChar = new char[] { ch3, ch2, ch1 };
            Console.WriteLine(string.Join(" ", arrChar));
        }
    }
}