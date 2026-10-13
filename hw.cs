int grade, count = 0, sum = 0;
int highest = 0, lowest = 100;
while (true)
{
    grade = int.Parse(Console.ReadLine());

    if (grade == -1)
        break;

    sum += grade;
    count++;

    if (grade > highest)
        highest = grade;

    if (grade < lowest)
        lowest = grade;
}
Console.WriteLine("Count: " + count);
Console.WriteLine("Sum: " + sum);
if (count > 0)
{
    Console.WriteLine("Average: " + (double)sum / count);
    Console.WriteLine("Highest: " + highest);
    Console.WriteLine("Lowest: " + lowest);
}
