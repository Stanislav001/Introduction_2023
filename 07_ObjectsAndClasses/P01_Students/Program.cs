namespace P01_Students;

class Program
{
    static void Main()
    {
        List<Subject> subjects = GenerateListOfSubjects();

        Student ivan = new Student(1, "Ivan", "Petrov", "Ruse", 20, subjects);
        Student gosho = new Student(2, "Gosho", "Georgiev", "Ruse", 15, subjects);

        ivan.GetSubjects();
        Console.WriteLine("====");
        gosho.GetSubjects();

        Console.WriteLine(ivan.AverageGrade());
        Console.WriteLine(gosho.AverageGrade());
    }

    private static List<Subject> GenerateListOfSubjects()
    {
        Subject web = new Subject(6, "Web");
        Subject datababe = new Subject(4, "Datababe");
        Subject cSharpPrograming = new Subject(5, "C#");

        List<Subject> subjects = new List<Subject>();
        subjects.Add(web);
        subjects.Add(datababe);
        subjects.Add(cSharpPrograming);

        return subjects;
    }
}