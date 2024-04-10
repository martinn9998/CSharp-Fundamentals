using System;

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{

    string intToString = Convert.ToString(i);
    char l = ' ';
    int sum = 0;
    for (int a = 0; a < intToString.Length; a++)
    {
        l = intToString[a];
        int intCharDigit = l - '0';
        int number = intCharDigit;
        sum = sum + number;

    }
    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}