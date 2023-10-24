namespace SimpleGame
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

            while (command != "STOP" && heroHP != 0)
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
        }
    }
}