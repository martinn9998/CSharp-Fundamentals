namespace CenturiesToMinutes
{
    class Program
    {
        public static void Main()
        {
            var cemturies = int.Parse(Console.ReadLine());
            var years = cemturies * 100;
            var days = (int)(years * 365.2422);
            var hours = days * 24;
            var minutes = hours * 60;
            Console.WriteLine($"{cemturies} centuries = {years:f0} years = {days:f0} days " +
                $"= {hours:f0} hours = {minutes:f0} minutes");

        }
    }
}