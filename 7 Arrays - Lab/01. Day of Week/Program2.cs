using System;

namespace DaysOfWeek
{
    class Program
    {
        public static void Main()
        {
            string[] strings =
            {
                "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday","Saturday",
                "Sunday"
            };
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(strings[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
} 