namespace FloatingEquality
{
    class Program
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double precision = 0.000001;
            if (Math.Abs(firstNumber - secondNumber) >= precision)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}