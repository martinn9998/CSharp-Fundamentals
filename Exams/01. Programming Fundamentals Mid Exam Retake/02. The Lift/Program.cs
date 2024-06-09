using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] liftCurrentState = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < liftCurrentState.Length; i++)
            {
                int availableSpace = 4 - liftCurrentState[i];
                if (people >= availableSpace)
                {
                    liftCurrentState[i] += availableSpace;
                    people -= availableSpace;
                }
                else
                {
                    liftCurrentState[i] += people;
                    people = 0;
                    break;
                }
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            else if (liftCurrentState.Any(wagon => wagon < 4))
            {
                Console.WriteLine("The lift has empty spots!");
            }

            Console.WriteLine(string.Join(" ", liftCurrentState));
        }
    }
}