namespace Vacation
{
    class Programm
    {
        public static void Main()
        {
            var countOfPeople = int.Parse(Console.ReadLine());
            var typeOfPeople = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();
            var price = 0.0;
            switch (dayOfTheWeek)
            {
                case "Friday":
                    switch (typeOfPeople)
                    {
                        case "Students":
                            price = 8.45;
                        break;
                        case "Business":
                            price = 10.90;
                            break;
                        case "Regular":
                            price = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfPeople)
                    {
                        case "Students":
                            price = 9.80;
                            break;
                        case "Business":
                            price = 15.60;
                            break;
                        case "Regular":
                            price = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfPeople)
                    {
                        case "Students":
                            price = 10.46;
                            break;
                        case "Business":
                            price = 16;
                            break;
                        case "Regular":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            var totalPrice = price * countOfPeople;
            if (typeOfPeople== "Students" && countOfPeople >=30)
            {
                totalPrice *= 0.85;
            }
            if (typeOfPeople == "Business" && countOfPeople >= 100)
            {
                totalPrice -= 10 * price;
            }
            if (typeOfPeople == "Business" && countOfPeople >=10 
                && countOfPeople <= 20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}