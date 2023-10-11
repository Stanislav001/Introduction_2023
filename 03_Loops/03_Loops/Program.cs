namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int credits = 0;

            Console.WriteLine("Now you have " + credits + " credits");

            Console.Write("Please enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("Please enter a student name: ");
                string studentName = Console.ReadLine();
                
                if (studentName.Length >= 5)
                {
                    credits += 10;
                }
                else
                {
                    credits += 5;
                }
            }

            Console.WriteLine("Now you have " + credits + " credits");
            
            string myName = "Ivan Ivanov Petrov";
            int charsOfMyName = myName.Length;
            
            for (int i = 0; i < myName.Length; i++)
            {
                Console.WriteLine(myName[i]);
            }

            Console.WriteLine("For loop");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration " + i);
            }

            Console.WriteLine();
            Console.WriteLine("While loop");

            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine("Iteration " + count);
                count++;
            }
        }
    }
}