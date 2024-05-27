/*
 1050
   200
   450
   2
   18.50 
   16.86 
   special
   
 */

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string client;
            decimal sum = 0m;
            decimal taxes = 0m;
            while ((client = Console.ReadLine()) != "special")
            {
                if (client == "regular")
                {
                    break;
                }
                decimal price = decimal.Parse(client);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                    sum = sum + price;
                    taxes += price * 0.2m;
            }
            decimal totalPrice = sum + taxes;
            if (client == "special")
            {
                totalPrice *= 0.9m;
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
