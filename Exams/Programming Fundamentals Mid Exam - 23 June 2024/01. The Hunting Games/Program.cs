using System.Diagnostics.Metrics;

namespace _01._The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double energyWholeGroup = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());

            double totalWater = numberOfDays * (numberOfPlayers * waterPerDayForOnePerson);
            double totalFood = numberOfDays * (numberOfPlayers * foodPerDayForOnePerson);
            int w = 1, f = 1;
            for (int i = 1; i <= numberOfDays; i++, f++, w++)
            {

                double energyLoss = double.Parse(Console.ReadLine());

                energyWholeGroup -= energyLoss;
                if (energyWholeGroup <= 0)
                {
                    break;
                }
                if (w == 2)
                {
                    totalWater -= totalWater * 0.30;
                    energyWholeGroup += energyWholeGroup * 0.05;
                    w = 0;
                }
                if (f == 3)
                {
                    totalFood = totalFood - totalFood / numberOfPlayers;
                    energyWholeGroup += energyWholeGroup * 0.10;
                    f = 0;
                }
                

            }
            if (energyWholeGroup <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");

            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyWholeGroup:f2} energy!");
            }

        }
    }
}
