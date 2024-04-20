namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Input()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }

        }
        static void Main(String[] args)
        {
            Input();
        }

    }
}