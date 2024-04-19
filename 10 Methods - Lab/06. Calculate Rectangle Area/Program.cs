public class RectangleArea
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double area = Calculation(a, b);
        Console.WriteLine(area);
    }
    static double Calculation(double a, double b)
    {
        return a * b;
    }
}