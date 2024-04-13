namespace SpiceMustFlow
{
    class Program
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhautionFactor = int.Parse(Console.ReadLine());
            int pokedTargetsCount = 0;
            int equality = pokePower / 2;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokedTargetsCount++;
                if ((pokePower==equality) && exhautionFactor > 0)
                {
                    pokePower /= exhautionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargetsCount);
        }
    }
}