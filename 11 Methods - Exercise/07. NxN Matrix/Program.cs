namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = Matrix(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(output);
            }

        }
        private static string Matrix(int n)
        {
            string output = "";
            for (int i = 0;i < n; i++)
            {
                output += n + " ";
            }

            return output;
        }
    }
}
