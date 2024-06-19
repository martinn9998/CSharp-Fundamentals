namespace SoftUniReception
{
    class Program
    {
        public static void Main()
        {
            int[] eployeeEfficiency = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int studentCount = int.Parse(Console.ReadLine());
        }
    }
}