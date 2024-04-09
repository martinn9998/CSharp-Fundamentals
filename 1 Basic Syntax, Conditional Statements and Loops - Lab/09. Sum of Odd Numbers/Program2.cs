namespace SumOfOddNumbers
{
    class Programm
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var i = 1;
            var sum = 0;
            while (count < n)
            {
                {
                    if (i%2==1)
                    {
                        Console.WriteLine(i);
                        count++;
                        sum += i;
                    }
                }
                i++;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}