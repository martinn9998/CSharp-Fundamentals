using System;
namespace PrintPartOfTheASCCIITable
{
    class Program
    {
        public static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}