namespace _06._Calculate_Rectangle_Area_Second_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(width, height));
        }
        static double RectangleArea (double width, double height)
        {
            double rectangleArea = width * height;
            return rectangleArea;
        }
    }
}
