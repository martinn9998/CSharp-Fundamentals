namespace SoftUniReception
{
    class Program
    {
        public static void Main()
        {
            int[] eployeeEfficiency = new int[3];
            for (int i = 0; i < 3; i++)
            {
                eployeeEfficiency[i] = int.Parse(Console.ReadLine());
            }
            int studentCount = int.Parse(Console.ReadLine());
            int h4 = 0, h4Count = 0;
            int maxPersonsPerHour = eployeeEfficiency.Sum();
            int hours = 0;
            while (studentCount > 0)
            {
                hours++;
                h4++;
                if (h4 == 4)
                {
                    h4 = 0;
                    hours--;
                }
                else
                {
                    studentCount -= maxPersonsPerHour;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}