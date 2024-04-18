using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main()
        {
            //Reading the size of the field.
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];
            //Reading initial indexes separated by " ".
            int[] ladyBugsPositions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < ladyBugsPositions.Length; i++)
            {
                if (ladyBugsPositions[i] < fieldSize && ladyBugsPositions[i] >= 0)
                {
                    field[ladyBugsPositions[i]] = 1;
                }
            }
            //Reading commands in format "{ladybug index} {direction} 
            //{fly length}", until you get the "end" command.
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int bugIndex = int.Parse(command[0]);

                if (bugIndex >= 0 && bugIndex < fieldSize)
                {
                    string direction = command[1];
                    int step = int.Parse(command[2]);

                    if (field[bugIndex] == 1)
                    {
                        field[bugIndex] = 0;
                        // Checking the direction.
                        if (direction == "right")
                        {
                            while (bugIndex + step < fieldSize && bugIndex + step >= 0)
                            {
                                if (field[bugIndex + step] == 0)
                                {
                                    field[bugIndex + step] = 1;
                                    break;
                                }
                                else
                                {
                                    bugIndex += step;
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            while (bugIndex - step < fieldSize && bugIndex - step >= 0)
                            {
                                if (field[bugIndex - step] == 0)
                                {
                                    field[bugIndex - step] = 1;
                                    break;
                                }
                                else
                                {
                                    bugIndex -= step;
                                }
                            }
                        }
                    }
                }
                //Reading next command.
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
