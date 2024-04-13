string[] userClass = new string[8] { "", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
string input = Console.ReadLine();

if (input.ToLower() == "1")
{
    Console.WriteLine(userClass[1]);
}
else if (input.ToLower() == "2")
{
    Console.WriteLine(userClass[2]);
}
else if (input.ToLower() == "3")
{
    Console.WriteLine(userClass[3]);
}
else if (input.ToLower() == "4")
{
    Console.WriteLine(userClass[4]);
}
else if (input.ToLower() == "5")
{
    Console.WriteLine(userClass[5]);
}
else if (input.ToLower() == "6")
{
    Console.WriteLine(userClass[6]);
}
else if (input.ToLower() == "7")
{
    Console.WriteLine(userClass[7]);
}

else
    Console.WriteLine("Invalid day!");

