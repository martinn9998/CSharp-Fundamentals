using System;

int n = int.Parse(Console.ReadLine());

    string intToString = Convert.ToString(n);
    char l = ' ';
    int sum = 0;
    for (int a = 0; a < intToString.Length; a++)
    {
        l = intToString[a];
        int intCharDigit = l - '0';
        int number = intCharDigit;
        sum = sum + number;

    }
Console.WriteLine(sum);
