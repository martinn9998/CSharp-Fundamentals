var countOfPeople = int.Parse(Console.ReadLine());
var typeGroup = Console.ReadLine();
var dayOfWeek = Console.ReadLine();
double price = 0;
if (dayOfWeek== "Friday")
{
    if (typeGroup == "Students")
    {
        price = 8.45;
    }
    else if (typeGroup == "Business")
    {
        price = 10.90;
    }
    else if (typeGroup == "Regular")
    {
        price = 15;
    }
}
else if(dayOfWeek == "Saturday")
{
    if (typeGroup == "Students")
    {
        price = 9.80;
    }
    else if (typeGroup == "Business")
    {
        price = 15.60;
    }
    else if (typeGroup == "Regular")
    {
        price = 20;
    }
}
else if (dayOfWeek == "Sunday")
{
    if (typeGroup == "Students")
    {
        price = 10.46;
    }
    else if (typeGroup == "Business")
    {
        price = 16;
    }
    else if (typeGroup == "Regular")
    {
        price = 22.50;
    }
}
double totalPrice = price * countOfPeople;

if (typeGroup == "Students" && countOfPeople>=30)
{
    totalPrice *= 0.85;
}
if (typeGroup == "Business" && countOfPeople >= 100)
{
    totalPrice -= (10 * price);
}
if (typeGroup == "Regular" && countOfPeople >= 10 && countOfPeople <=20)
{
    totalPrice *= 0.95;
}

Console.WriteLine($"Total price: {totalPrice:f2}");