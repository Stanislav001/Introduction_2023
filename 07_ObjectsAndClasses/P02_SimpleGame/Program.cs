namespace P02_SimpleGame;

public class Program
{
    public static void Main()
    {
        Item weapon = new Item("Weapon", 30);
        Item armor = new Item("Armor", 50);
        Item ring = new Item("Ring", 10);

        List<Item> items = new List<Item>() { weapon, armor, ring };

        // hero name 
        // balance -> 100
        // hp -> 10
        Hero hero = new Hero(3, "Pesho", 100);

        Console.Write("Enter command: ");
        string command = Console.ReadLine();

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

            Console.Write("Enter command: ");
            command = Console.ReadLine();
        }

        hero.GetEndInfo();
    }
}