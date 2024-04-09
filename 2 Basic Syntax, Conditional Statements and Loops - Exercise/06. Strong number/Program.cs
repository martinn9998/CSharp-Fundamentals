using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            int digit = imput.Length;

            int number = int.Parse(imput);
            int strongNumber = number;

            int sum = 0;

            int factorial = 0;

            int factorialSum = 1;

            for (int i = 0; i < digit; i++)
            {
                factorial = number % 10;

                for (int a = 1; a <= factorial; a++)
                {
                    factorialSum *= a;
                }
                sum += factorialSum;

                factorialSum = 1;
                factorial = 0;

                number /= 10;
            }



            if (sum.Equals(strongNumber))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}