namespace Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = decimal.Parse(Console.ReadLine());
            if (input>=3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }

        }
    }
}
