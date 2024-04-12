namespace Elevator
{
    class Program
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var elevatorCapacity = int.Parse(Console.ReadLine());
            var courses = (int)Math.Ceiling((double)numberOfPeople/elevatorCapacity);
            Console.WriteLine(courses);
        }
    }
}