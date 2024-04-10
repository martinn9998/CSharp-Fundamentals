int n = int.Parse(Console.ReadLine());
string word = "";
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int numberOfDigits = input.Length;
    char mainDigit = ' ';
    for (int j = 0; j < numberOfDigits; j++)
    {
        mainDigit = input[j];
    }
    int digit = mainDigit - '0';
    if (digit == 0)
    {
        word += " ";
        continue;
    }
    int offset = (digit - 2) * 3;
    if (digit == 8 || digit == 9)
    {
        offset++;
    }
    int index = (offset + numberOfDigits - 1);
    int charIndex = index + 97;
    char letter = (char)charIndex;
    string letterStr = letter.ToString();
    word += letterStr;

}
Console.WriteLine(word);