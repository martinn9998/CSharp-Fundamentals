namespace PadawanEquipment
{
    class Program
    {
        public static void Main()
        {
            var moneyAvailable = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var priceOfLightsaber = double.Parse(Console.ReadLine()); //10% more round up
            var priceOfRobe = double.Parse(Console.ReadLine());
            var priceOfBelt = double.Parse(Console.ReadLine()); //every sixth belt is free
            var calulationLightsabers = Math.Ceiling(students * 1.10) * priceOfLightsaber;
            var calculationRobes = students * priceOfRobe;
            int c = 1, freebelt = 1;
            var calculationBelts = students * priceOfBelt;
            for (int i = 1; i <=students;i++,freebelt++)
            {
                if (freebelt==6)
                {
                    calculationBelts -= priceOfBelt;
                    freebelt = 0;
                }
            }
            
            var expenses = calulationLightsabers + calculationRobes + calculationBelts;
            if (moneyAvailable>=expenses)
            {
                Console.WriteLine($"The money is enough - it would cost {expenses:f2}lv.");
            }
            else
            {
                var moneyNeeded = expenses - moneyAvailable;
                Console.WriteLine($" John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}