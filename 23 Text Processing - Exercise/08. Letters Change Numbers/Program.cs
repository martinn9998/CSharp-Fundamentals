namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> str = Console
                .ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<double> sums = new List<double>();
            for (int i = 0; i < str.Count; i++)
            {
                double currSum = 0;
                string currStringNumber = "";
                int numbersCount = 1;
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i][j] >= 48 && str[i][j] <= )
                }
            }
        }
    }
}
