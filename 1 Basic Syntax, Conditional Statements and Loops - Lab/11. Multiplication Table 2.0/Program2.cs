namespace MultiplicationTable2_0
{
    class Programm
    {
        public static void Main()
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            if (n2 < 10)
            {
                for (int i = n2; i <= 10; i++)
                {
                    Console.WriteLine($"{n1} X {i} = {n1 * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n1} X {n2} = {n1 * n2}");
            }
        }
    }
}