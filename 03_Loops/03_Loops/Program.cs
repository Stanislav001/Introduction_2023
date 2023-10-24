using System.Text.RegularExpressions;

namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter money: ");
            int heroMoney = int.Parse(Console.ReadLine());

            Console.Write("Enter hp of hero: ");
            int heroHP = int.Parse(Console.ReadLine());

            Console.Write("Enter a comamnd: ");
            int countHeroItems = 0;
            
            string command = Console.ReadLine();

            while(command != "STOP" && heroHP != 0)
            {
                if (command == "buy")
                {
                    Console.Write("Enter a item price: ");
                    int itemPrice = int.Parse(Console.ReadLine());

                    if (itemPrice <= heroMoney)
                    {
                        countHeroItems += 1;
                        heroMoney -= itemPrice;
                        Console.WriteLine("You have " + countHeroItems + " items and " + heroMoney + " $");
                    }
                }

                if (command == "deposit")
                {
                    Console.Write("Enter a deposit sum: ");
                    int depositSum = int.Parse(Console.ReadLine()); 

                    heroMoney += depositSum;

                    Console.WriteLine("Now you have " + heroMoney + " $");
                }

                if (command == "attack")
                {
                    if (heroHP > 0)
                    {
                        heroHP -= 1;

                        Console.WriteLine("Now you have " + heroHP + " hp");
                    }
                }

                if (heroHP == 0)
                {
                    Console.Write("You have 0 hp");
                    break;
                }
                else
                {
                    Console.Write("Enter a comamnd: ");
                    command = Console.ReadLine();
                }
            }









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