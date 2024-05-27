
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
            int j = 0;
            bool isItTrue = false;
            for (int i = 0; i < liftCurrentState.Length; i++)
            {
                if (people >= 4)
                {
                    for (; j < liftCurrentState.Length;)
                    {
                        if (liftCurrentState[j] > 0)
                        {
                            int currentNumberForArray = liftCurrentState[j];
                            people -= 4 - currentNumberForArray;
                            liftCurrentState[j] += (4 - currentNumberForArray);
                        }
                        else if (liftCurrentState[j] == 0)
                        {
                            liftCurrentState[j] += 4;
                            people -= 4;
                        }
                            j++;
                        
                        break;
                    }
                    continue;
                }
                else if (people < 4 && people > 0)
                {
                    for (; j < liftCurrentState.Length; )
                    {
                        liftCurrentState[j] += people;
                        people -= liftCurrentState[j];
                        i = liftCurrentState.Length;
                        break;
                    }
                    continue;
                }
            }

            if (people > 0)
            {
                isItTrue = true;
            }
            else if (people <= 0)
            {
                isItTrue = false;
            }

            if (isItTrue)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", liftCurrentState));
            }
            else
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", liftCurrentState));
            }
        }
    }
}
