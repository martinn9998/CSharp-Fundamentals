using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int count2 = 0, count3 = 0;
            string input = Console.ReadLine();
            string output = "";
            int if1 = Ch6And10(input, count1);
            int if2 = OnlyLAD(input, count2);
            int if3 = AtLeast2Digits(input, count3);
            int s = 0;
            if (if1 > 0)
            {
                output += "Password must be between 6 and 10 characters" + " |";
                s++;
            }
            if (if2 > 0)
            {
                output += "Password must consist only of letters and digits" + " |";
                s++;
            }
            if (if3 > 0)
            {
                output += "Password must have at least 2 digits" + " |";
                s++;
            }
            if (s == 0)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                string[] arrOutput = output
                    .Split('|')
                    .ToArray();
                foreach (string str in arrOutput)
                {
                    Console.WriteLine(str);
                }
            }

        }
        static int Ch6And10(string input, int count1)
        {
            if ((input.Length > 10 || input.Length < 6))
            {
                count1++;
            }
            return count1;
        }
        static int OnlyLAD(string input, int count2)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (!char.IsLetterOrDigit(letter))
                {
                    count2++;
                }

            }
            return count2;
        }
        static int AtLeast2Digits(string input, int count3)
        {
            int countDigit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (char.IsDigit(letter))
                {
                    countDigit++;
                }
            }
            if (countDigit < 2)
            {
                count3++;
            }
            return count3;
        }
    }
}
