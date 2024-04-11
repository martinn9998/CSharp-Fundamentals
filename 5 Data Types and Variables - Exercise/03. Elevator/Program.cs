int numberOfPeople = int.Parse(Console.ReadLine());
int capacityOfPersons = int.Parse(Console.ReadLine());
int mainCourses = numberOfPeople / capacityOfPersons;
int additionalCourses = numberOfPeople % capacityOfPersons;
int courses = 0;

if (capacityOfPersons > numberOfPeople)
{
    courses = 1;
}
else
{
    if (additionalCourses > 0)
    {
        courses = mainCourses + 1;
    }
    else
    {
        courses = mainCourses;
    }
}
Console.WriteLine(courses);