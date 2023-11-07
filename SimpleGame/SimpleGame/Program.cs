namespace SimpleGame
{
    internal class Program
    {
        static void Main()
        {
            Run();
        }
        private static void Run()
        {
            int countHeroItems = 0;
            int heroMoney = ReadIntNumberFromConsole("Enter money: ");
            int heroHP = ReadIntNumberFromConsole("Enter hp of hero: ");

            Console.Write("Enter a comamnd: ");
            string command = Console.ReadLine();

            while (command != "STOP" && heroHP != 0)
            {
                if (command == "buy")
                {
                    Buy(heroMoney, countHeroItems);
                }

                if (command == "deposit")
                {
                    int deposedMoney = ReadIntNumberFromConsole("Enter a deposit sum: ");

                    heroMoney += deposedMoney;

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

        private static int ReadIntNumberFromConsole(string helperText)
        {
            Console.Write(helperText);
            int input = int.Parse(Console.ReadLine());

            return input;
        }

        private static void Buy(int money, int itemsCount)
        {
            int itemPrice = ReadIntNumberFromConsole("Enter a item price: ");

            money -= itemPrice;
            itemsCount += 1;

            Console.WriteLine("You have " + itemsCount + " items and " + money + " $");
        }
    }
}