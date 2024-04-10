Console.Write("Length: ");
double lenght = double.Parse(Console.ReadLine());
Console.Write("Width: ");
double widhth = double.Parse(Console.ReadLine());
Console.Write("Height: ");
double height = double.Parse(Console.ReadLine());
double V0 = (lenght * widhth * height) / 3;
Console.Write($"Pyramid Volume: {V0:f2}");
