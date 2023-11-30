namespace P02_SimpleGame;

public class Program
{
    public static void Main()
    {
        Item weapon = new Item("Weapon", 30);
        Item armor = new Item("Armor", 50);
        Item ring = new Item("Ring", 10);

        List<Item> items = new List<Item>() { weapon, armor, ring };

        string heroName = ReadStringFromConsole("Enter hero name: ");

        Hero hero = new Hero(heroName);

        string command = ReadStringFromConsole("Enter command: ");

        while (command != "stop")
        {
            if (command == "attack")
            {
                hero.Attack();
            }

            if (command == "buy")
            {
                string itemName = ReadStringFromConsole("Enter name of item: ");
                
                Item existingItem = items.Find(item => item.Name.ToLower() == itemName.ToLower());

                if (existingItem != null)
                {
                    if (hero.Balance >= existingItem.Price)
                    {
                        Item heroItem = new Item(existingItem.Name, existingItem.Price);
                        hero.AddItem(heroItem);
                    }
                    else
                    {
                        Console.WriteLine($"Your dont have enought money for this item.");
                    }
                }
                else
                {
                    Console.WriteLine($"Item '{itemName}' not found in the list.");
                }
            }

            if (command == "deposit")
            {
                Console.Write("Enter money: ");
                double money = double.Parse(Console.ReadLine());
                hero.DepositMoney(money);
            }

            if (command == "info")
            {
                hero.GetInformation();
            }

            command = ReadStringFromConsole("Enter command: ");
        }
        hero.GetInformation();
    }

    private static string ReadStringFromConsole(string helperHelp)
    {
        Console.Write(helperHelp);
        string input = Console.ReadLine();

        return input;
    }
}