namespace P02_SimpleGame;

public class Program
{
    public static void Main()
    {
        List<Item> items = new List<Item>();

        Hero hero = new Hero(3, "Pesho", 300, items);

        Console.Write("Enter command: ");
        string command = Console.ReadLine();

        // First Item -> 40
        // Second Item -> 90
        // Third Item -> 20

        while (command != "stop")
        {
            if (command == "attack")
            {
                hero.Attack();
            }

            if (command == "buy")
            {
                Console.Write("Enter name of item: ");
                string itemName = Console.ReadLine();

                Item item = new Item(itemName, 40);
                hero.AddItem(item);
            }

            if (command == "deposit")
            {
                Console.Write("Enter money: ");
                double money = double.Parse(Console.ReadLine());
                hero.DepositMoney(money);
            }

            Console.Write("Enter command: ");
            command = Console.ReadLine();
        }
    }
}