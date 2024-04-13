namespace RefactoringNameSpace
{
    class Program
    {
        public static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numberToCheck; i++)
            {
                bool isPrime = true;
                for (int t = 2; t < i; t++)
                {
                    if (i % t == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());
            }

        }
    }
}