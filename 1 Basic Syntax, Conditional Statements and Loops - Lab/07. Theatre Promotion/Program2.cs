using System;
namespace TheatrePromotions
{
    class Program
    {
        public static void Main()
        {

            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            if (64 < age && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (typeOfDay == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (typeOfDay == "Holiday")
                {
                    Console.WriteLine("10$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (18 < age && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (typeOfDay == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else if (typeOfDay == "Holiday")
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (0 <= age &&  age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (typeOfDay == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (typeOfDay == "Holiday")
                {
                    Console.WriteLine("5$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
