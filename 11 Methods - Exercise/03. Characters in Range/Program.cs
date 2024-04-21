namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            Console.Write(Output(ch1, ch2));


            static string Output(char ch1, char ch2)
            {
                string chO = "";
                int n1 = ch1;
                int n2 = ch2;
                if (n1 < n2)
                {
                    for (int i = n1; i < n2; i++)
                    {
                        if (i == n1)
                        {
                            continue;
                        }
                        char letter = (char)i;
                        chO += letter + " ";
                    }
                }
                else
                {
                    int nn1 = n2;
                    int nn2 = n1;
                    for (int i = nn1; i < nn2; i++)
                    {
                        if (i == nn1)
                        {
                            continue;
                        }
                        char letter = (char)i;
                        chO += letter + " ";
                    }
                }
                return chO;


            }
        }

    }
}


