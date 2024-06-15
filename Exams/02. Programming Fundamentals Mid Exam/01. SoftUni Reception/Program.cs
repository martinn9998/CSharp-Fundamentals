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
            for (int i = 0; i < sequence.Count; i++)
            {
                double value = sequence[i];
                sum += value;
            }
            double average = Math.Round(sum / sequence.Count, 2); ;
            List<int> greaterThanAverage = new List<int>();
            foreach (int value in sequence)
            {
                if (value > average)
                {
                    greaterThanAverage.Add(value);
                }
            }
            greaterThanAverage = greaterThanAverage.OrderByDescending(x => x.Name).ToList();


        }
    }
}