namespace Overflow
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double addition = double.Parse(Console.ReadLine());
                if (sum + addition>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += addition;
                }
            }
            Console.WriteLine(sum);
        }
    }
}