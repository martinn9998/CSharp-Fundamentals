namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            n1 = FirstFactorial(n1);
            n2 = SecondFactorial(n2);
            double division = Division(n1, n2);
            Console.WriteLine($"{division:f2}");

        }
        private static int FirstFactorial(int n1)
        {
            for (int i = n1 - 1; i > 0; i--)
            {
                n1 *= i;
            }
            return n1;
        }
        private static int SecondFactorial(int n2)
        {
            for (int i = n2 - 1; i > 0; i--)
            {
                n2 *= i;
            }
            return n2;
        }
        private static double Division(int n1, int n2)
        {
            int n1D = n1, n2D = n2;
            double division = n1D / n2D;
            return division;
        }
    }
}
