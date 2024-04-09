namespace StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            decimal averageGrade = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");
        }
    }
}
