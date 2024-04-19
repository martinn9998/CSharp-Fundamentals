class MathPower
{
    static void Main()
    {
        int theBase = int.Parse(Console.ReadLine());
        int thePower = int.Parse(Console.ReadLine());
        MathCalculation(theBase, thePower);
        

    }
    static double MathCalculation(int theBase, int thePower)
    {
        double calculation = Math.Pow(theBase, thePower);
        Console.WriteLine(calculation);
        return (calculation);
    }
}