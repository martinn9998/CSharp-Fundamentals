namespace TriangleOfNumbers
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Rows(n);
        }
        static void Rows(int n)
        {
            for (int rows = 1; rows <= n; rows++)
            {
                Cols(rows);
                Console.WriteLine();
            }
        }
        static void Cols(int rows)
        {
            for (int cols = 1; cols <= rows; cols++)
            {
                Console.Write(rows + " ");
            }
        }
    }
}