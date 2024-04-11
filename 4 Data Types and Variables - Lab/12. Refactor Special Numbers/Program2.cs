namespace RefactorSpecialNumbers
{
    class Program
    {
        public static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            int number = 0;
            bool isFalse = false;
            for (int i = 1; i <= counter; i++)
            {
                int sum = 0;
                number = i;
                while (number > 0)
                {
                    sum += number % 10;
                     number /= 10;
                }
                isFalse = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isFalse);
            }
        }
    }
}