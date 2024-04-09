namespace StrongNumber
{
    class Programm
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            bool isItStrong = IsItStrong(n);
            if (isItStrong)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
        private static bool IsItStrong(int n)
        {
            bool isItStrong = false;
            var sum = SumOfFactorials(n);
            if (sum==n)
            {
                isItStrong = true;
            }
            return isItStrong;
        }
        private static int SumOfFactorials(int n)
        {
            var sum = 0;
            string strSum = n.ToString();
            var number = 0;
            for (var i = strSum.Length-1;i>=0;i--)
            {
                number = n % 10;
                var factorial = Factorial(number);
                sum += factorial;
                n /= 10;
            }
            return sum;
        }
        private static int Factorial(int number)
        {
            var factorial = 0;
            for (var p = number; p > 1; p--)
            {
                if (p == number)
                {
                    factorial = p;
                    factorial *= (p - 1);
                }
                else
                {
                    factorial *= (p - 1);
                }
            }
            if (factorial == 0)
            {
                factorial = 1;
            }
                return factorial;
        }
    }
}