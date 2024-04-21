namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!= "END")
            {
                bool palindrome = Palindrome(input);
                if (palindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
        private static bool Palindrome(string input)
        {
            string backwards = string.Empty;
            bool palindrome = false;
            for (int i = input.Length - 1; i>=0;i--)
            {
                char letter = input[i];
                backwards += letter;
            }
            if (backwards==input)
            {
                palindrome = true;
            }

            return palindrome;
        }
    }
}
