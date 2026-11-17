Course[] courses = {
    new("CENG211", "Object Oriented Programming", 4),
    new("MATH101", "Calculus I", 5),
    new("PHYS102", "Physics II", 4),
    new("ENG101", "Academic English", 3),
    new("HIST201", "History of Civilization", 2)
};

int total = 0;
string[] names = new string[courses.Length];

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Info());
    total += courses[i].Credits;
    names[i] = courses[i].Name;
}

Console.WriteLine($"\nTotal Credits: {total}\n\nSorted Names:");
Array.Sort(names);
foreach (var name in names)
    Console.WriteLine(name);

class Course
{
    public string Code { get; init; }
    public string Name { get; set; }

    private int credits;
    public int Credits
    {
        get => credits;
        set => credits = (value >= 1 && value <= 10) ? value : throw new ArgumentException("1-10 arası olmalı");
    }

    public Course(string code, string name, int credits) => (Code, Name, Credits) = (code, name, credits);
    public string Info() => $"{Code} {Name} ({Credits} cr)";
}
