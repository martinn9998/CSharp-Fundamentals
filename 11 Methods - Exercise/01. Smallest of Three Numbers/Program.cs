namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(a , b , c));
        }
        static int SmallestNumber(int a, int b, int c)
        {
            int smallestNumber = int.MaxValue;
            for (int i = 1; i <= 3; i++)
            {
                if(i==1)
                {
                    if (a < smallestNumber)
                    {
                        smallestNumber = a;
                    }
                }
                else if (i == 2)
                {
                    if (b < smallestNumber)
                    {
                        smallestNumber = b;
                    }
                }
                else if (i == 3)
                {
                    if (c < smallestNumber)
                    {
                        smallestNumber = c;
                    }
                }
            }
            return smallestNumber;

        }

    }
}
