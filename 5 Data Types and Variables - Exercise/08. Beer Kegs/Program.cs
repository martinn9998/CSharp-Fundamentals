int n = int.Parse(Console.ReadLine());
double maxValume = int.MinValue;
string maxVolumeModel = string.Empty;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double currentVolume = Math.PI * Math.Pow(radius, 2) * height;
    if (currentVolume > maxValume)
    {
        maxValume = currentVolume;
        maxVolumeModel = model;
    }
}
Console.WriteLine(maxVolumeModel);
