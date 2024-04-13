int n = int.Parse(Console.ReadLine());
bool spaceBool = true;
int sumFN = 0, sumSN = 0, number1 = 0, number2 = 0;
for (int i = 1; i <= n; i++)
{
    string input = Console.ReadLine();
    char spaceChar = ' ';
    for (int j = 0; j < input.Length; j++)
    {
        char letter = input[j];
        if (letter != spaceChar && spaceBool)
        {
           number1 = letter - '0';
            sumFN += number1;
        }
        else if (letter == spaceChar) 
        {
            spaceBool = false; 
        }

        else
        {
            if (letter != spaceChar)
            {
                number2 = letter - '0';
                sumSN += number2;
            }
        }

    }
    if (sumFN>sumSN)
    {
        Console.WriteLine(sumFN);
    }
    else
    {
        Console.WriteLine(sumSN);
    }
    sumFN = 0;
    sumSN = 0;
    spaceBool = true;
}