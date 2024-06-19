using System.Linq;

namespace Numbers
{
    class Program
    {
        public static void Main()
        {
            List<int> sequence = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double sum = 0;
            if (sequence.Count == 1)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < sequence.Count; i++)
            {
                double value = sequence[i];
                sum += value;
            }
            double average = Math.Round(sum / sequence.Count, 2);
            List<int> greaterThanAverage = new List<int>();
            foreach (int value in sequence)
            {
                if (value > average)
                {
                    greaterThanAverage.Add(value);
                }
            }
            greaterThanAverage = greaterThanAverage.OrderByDescending(x => x).ToList();
            if (greaterThanAverage.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{greaterThanAverage[i]} ");
                }
            }
            else
            {
                for (int i = 0; i < greaterThanAverage.Count; i++)
                {
                    Console.Write($"{greaterThanAverage[i]} ");
                }
            }
        }
    }
}