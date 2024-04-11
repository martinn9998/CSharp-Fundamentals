namespace RefactorVolumeOfPyramid
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var heigth = double.Parse(Console.ReadLine());
            var v = (length * width * heigth) / 3;
            Console.Write($"Pyramid Volume: {v:f2}");
        }
    }
}