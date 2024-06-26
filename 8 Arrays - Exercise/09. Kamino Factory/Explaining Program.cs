using System;
using System.Linq;
namespace KaminoFactory
{
    class Program
    {
        static void Main()
        {
            //Reading DNA length:
            Console.ReadLine();
            string[] bestDna = null;
            int bestOnes = -1;
            int startIndex = -1;
            int bestDnaSum = 0;
            int bestSampleIndex = 0;
            int currentSampleIndex = 0;

            while (true)
            {
                //Reading DNA sequence of ones and zeroes until
                //command "Clone them":
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                string[] currentDna = input.Split('!', StringSplitOptions.RemoveEmptyEntries);
                int currentOnes = 0;
                int currentBestOnes = 0;
                int currentEndIndex = 0;
                //Counting ones in array:
                for (int a = 0; a < currentDna.Length; a++)
                {
                    if (currentDna[a] == "1")
                    {
                        currentOnes++;
                        if (currentOnes > currentBestLen)
                        {
                            currentEndIndex = a;
                            currentBestOnes = currentLen;
                        }
                    }
                    else
                    {
                        currentOnes = 0;
                    }
                }
                //Calculating currentStartIndex:
                int currentStartIndex = currentEndIndex - currentBestOnes + 1;

                bool isCurrentDnaBetter = false;
                //Adding current array to Sum Array:
                int currentDnaSum = currentDna.Select(int.Parse).Sum();
                //Cheking if current array is bigger from the
                //best array:
                if (currentBestOnes > bestOnes)
                {
                    isCurrentDnaBetter = true;
                }
                else if (currentBestOnes == bestOnes)
                {
                    if (currentStartIndex < startIndex)
                    {
                        isCurrentDnaBetter = true;
                    }
                    else if (currentStartIndex == startIndex)
                    {
                        if (currentDnaSum > bestDnaSum)
                        {
                            isCurrentDnaBetter = true;
                        }
                    }
                }
                //Counting arrays:
                currentSampleIndex++;
                //Cheking the boolean value:
                if (isCurrentDnaBetter)
                {
                    bestDna = currentDna;
                    bestOnes = currentBestOnes;
                    startIndex = currentStartIndex;
                    bestDnaSum = currentDnaSum;
                    bestSampleIndex = currentSampleIndex;
                }
            }
            //Printing the best Array and the values in it:
            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}