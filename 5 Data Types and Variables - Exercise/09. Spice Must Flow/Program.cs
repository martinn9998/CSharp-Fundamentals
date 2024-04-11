int yeld = int.Parse(Console.ReadLine());
int leavingYeld = 0, sum = 0, days = 0;
while (true)
{
    days++;
    leavingYeld = yeld - 26;
    sum += leavingYeld;
    yeld -= 10;
    if (yeld<100)
    {
        break;
    }
}
sum -= 26;
if (sum<0)
{
    sum = 0;
}
Console.WriteLine(days);
Console.WriteLine(sum);