namespace ReverseArrayOfStrings
{
    class Program
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine()
                .Split();
            for (int i = strings.Length-1; i >= 00; i--)
            {
                Console.Write(strings[i] + " ");
            }
        }
    }
}