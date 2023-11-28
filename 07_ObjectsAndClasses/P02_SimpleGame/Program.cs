namespace P02_SimpleGame;

public class Program
{
    public static void Main()
    {
        Item firstItem = new Item(30);
        Item secondItem = new Item(70);

        List<Item> items = new List<Item>();

        Hero hero = new Hero(3, "Pesho", 300, items);

        hero.AddItem(firstItem);
        hero.AddItem(secondItem);

        hero.DepositMoney(50);
        hero.Attack();
    }
}

