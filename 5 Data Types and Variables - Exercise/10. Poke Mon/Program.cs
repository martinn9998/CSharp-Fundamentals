double n = double.Parse(Console.ReadLine()); // poke power
double m = double.Parse(Console.ReadLine());  // distance 
double y = double.Parse(Console.ReadLine()); // exhaustionFactor
double pocked = 0, n0 = 0, division = 0;
n0 = n;
bool fiftyPerc = false;
while (n0>m)
{
    n0 -= m;
    pocked++;
    if (n0==n * 0.5)
    {
        division = Math.Floor(n0 / y);
        fiftyPerc = true;
        continue; ;
    }
}
//Your task is to start subtracting M from N until N becomes less than M
//, i.e. the Pokemon does not have enough power to reach the next target. 
//Every time you subtract M from N that means you've reached a target 
//    and poked it successfully. COUNT how many targets you've poked – you'll
//    need that count.
//The PokeMon becomes gradually more exhausted. IF N becomes equal to 
//    EXACTLY 50 % of its original value, you must divide N by Y,
//    if it is POSSIBLE. This DIVISION is between integers.
//If a division is not possible, you should NOT do it.
//Instead, you should continue subtracting.
//After dividing, you should continue subtracting from N,
//until it becomes less than M.
//When N becomes less than M,
//you must take what has remained of N and the count of
//targets you've poked, and print them as output.
//NOTE: When you are calculating percentages, you should be PRECISE at maximum.
//Example: 505 is NOT EXACTLY 50 % from 1000, its 50.5 %.

if (fiftyPerc)
{
    Console.WriteLine(division);
    Console.WriteLine(pocked);
}
else
{
    Console.WriteLine(n0);
    Console.WriteLine(pocked);
}