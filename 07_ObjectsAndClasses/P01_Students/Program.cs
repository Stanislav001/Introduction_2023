namespace P01_Students;

class Program
{
    static void Main()
    {
        Student student = new Student()
        {
            FirstName = "Pesho",
            LastName = "Ivanov",
            City="Sofia",
            Age = 20
        };
        student.FirstName = "Dragan";

        Student ivan = new Student("Ivan", "Petrov", "Ruse", 20);

        Student gosho = new Student("Gosho", "Georgiev", "Ruse", 15);

        gosho.SayHello(ivan.FirstName);
        gosho.IdCard();

        ivan.IdCard();
    }
}