namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nS = Console.ReadLine();
            int n = int.Parse(nS);
            for (int i = 1; i <= n; i++)
            {
                string iS = i.ToString();
                bool divisible = Divisable(iS);
                bool holdsOneOdd = HoldsOneOdd(iS);
                if (divisible && holdsOneOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static bool Divisable(string iS)
            {
            bool divisible = false;
            int sum = 0;
            for (int j = 0; j < iS.Length; j++)
            {
                char letter = iS[j];
                int number = letter - '0';
                int number0 = number;
                sum += number0;
            }
            if (sum%8==0)
            {
                divisible = true;
            }
            return divisible;
            }
        private static bool HoldsOneOdd(string iS)
        {
            bool holdsOneOdd = false;
            for (int i = 0;i < iS.Length; i++)
            {
                char letter = iS[i];
                int number = letter - '0';
                if (number % 2 == 1)
                {
                    holdsOneOdd = true;
                }
            }
            return holdsOneOdd;
        }
        
    }
}
