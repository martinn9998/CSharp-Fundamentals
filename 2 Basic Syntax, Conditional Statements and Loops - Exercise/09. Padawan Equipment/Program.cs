var ammountMoneyJohn = double.Parse(Console.ReadLine());
double countOfStudents = double.Parse(Console.ReadLine());
double priceOfLightsaber = double.Parse(Console.ReadLine());
double priceOfRobe = double.Parse(Console.ReadLine());
double priceOfBelt = double.Parse(Console.ReadLine());
int freeBelt = 1;
double beltCalculation = 0;

for (int i = 1; i <= countOfStudents; i++, freeBelt++)
{
    beltCalculation += priceOfBelt;
    if (freeBelt == 6)
    {
        beltCalculation -= priceOfBelt;
        freeBelt = 0;
    }
}

double robesCalculation = priceOfRobe * countOfStudents;

double lightsaberBreakCountOfStudents = Math.Ceiling(1.10 * countOfStudents);
double lightsaberCalculation = priceOfLightsaber * lightsaberBreakCountOfStudents;

double priceSum = beltCalculation + robesCalculation + lightsaberCalculation;

if (priceSum <= ammountMoneyJohn)
{
    Console.WriteLine($"The money is enough - it would cost {priceSum:f2}lv.");
}
else
{
    double result = priceSum - ammountMoneyJohn;
    Console.WriteLine($" John will need {result:f2}lv more.");
}