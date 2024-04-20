public class PrintingTriangle
{
    static void Main(string[] args)
    {
        int start = 1;
        int end = int.Parse(Console.ReadLine());
        PrintLine(start, end);
        ReversePrintLine(start, end);
    }
    static void PrintLine(int start, int end)
    {
        int col = 1;
        for (int i = start; i <= end; i++)
        {
            for (; col <= i; col++)
            {
                Console.Write(col + " ");
            }
            col = 1;
            Console.WriteLine();
        }
    }
    static void ReversePrintLine(int start, int end)
    {
        int col = 1;
        for (int i = end - 1; i >= start; i--)
        {
            for (; col <= i; col++)
            {
                Console.Write(col + " ");
            }
            col = 1;
            Console.WriteLine();
        }
    }
}
