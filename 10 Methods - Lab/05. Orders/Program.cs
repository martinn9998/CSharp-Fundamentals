class Orders
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Output(input);
    }
    static void Output(string input)
    {
        double price = 0, sum = 0;
        int quantity = int.Parse(Console.ReadLine());
        switch (input)
        {
            case "coffee":
                price = 1.50;
                break;
            case "water":
                price = 1.00;
                break;
            case "coke":
                price = 1.40;
                break;
            case "snacks":
                price = 2.00;
                break;
        }
        double finalPrice = price * quantity;
        Console.WriteLine($"{finalPrice:F2}");
    }
}