using System.Runtime.Serialization.Formatters;

namespace ReverseString
{
    class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var reversed = Reversed(text);
            Console.WriteLine(reversed);

        }
        private static string Reversed(string text)
        {
            var reversed = "";
            for (int i = text.Length-1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }
    }
}