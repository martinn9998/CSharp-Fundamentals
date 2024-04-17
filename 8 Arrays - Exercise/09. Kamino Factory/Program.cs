using System;
using System.Linq;
namespace KaminoFactory
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            string[] bestDna = null;
            int bestOnes = -1;
            int startIndex = -1;
            int bestDnaSum = 0;
            int bestSampleIndex = 0;
            int currentSampleIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                string[] currentDna = input.Split('!', StringSplitOptions.RemoveEmptyEntries);
                int currentOnes = 0;
                int currentBestOnes = 0;
                int currentEndIndex = 0;

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

                int currentStartIndex = currentEndIndex - currentBestOnes + 1;

                bool isCurrentDnaBetter = false;
                int currentDnaSum = currentDna.Select(int.Parse).Sum();

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

                currentSampleIndex++;

                if (isCurrentDnaBetter)
                {
                    bestDna = currentDna;
                    bestOnes = currentBestOnes;
                    startIndex = currentStartIndex;
                    bestDnaSum = currentDnaSum;
                    bestSampleIndex = currentSampleIndex;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}