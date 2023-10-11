using System.Runtime.CompilerServices;

namespace _02_ConditionalConstructsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("name: " + name + ",Age: " + age);
            //Console.WriteLine($"name: {name}, Age: {age}, Money: {money}");

            int number = 20;

            // 20 / 2 = 10
            // 20 % 2 = 0

            int temperature = 25;

            if (temperature >= 30)
            {
                Console.WriteLine("It's a hot day.");
            }
            else 
            {
                Console.WriteLine("It's not very hot today.");
            }

            char grade = 'Y';
           
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory.");
                    break;
                default:
                    Console.WriteLine("Please work harder.");
                    break;
            }
        }
    }
}