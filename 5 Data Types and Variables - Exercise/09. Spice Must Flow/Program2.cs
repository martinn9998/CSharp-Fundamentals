namespace SpiceMustFlow
{
    class Program
    {
        public static void Main()
        {
            int startingYeld = int.Parse(Console.ReadLine());
            int totalDaysCounter = 0;
            int totalAmmountOfSpices = 0;
            if (startingYeld >= 100)
            {
                while (startingYeld >= 100)
                {
                    totalAmmountOfSpices += startingYeld - 26;
                    startingYeld -= 10;
                    totalDaysCounter++;
                }
                Console.WriteLine(totalDaysCounter);
                Console.WriteLine(totalAmmountOfSpices - 26);
            }
            else
            {
                Console.WriteLine(totalDaysCounter);
                Console.WriteLine(totalAmmountOfSpices);
            }
        }
    }
}