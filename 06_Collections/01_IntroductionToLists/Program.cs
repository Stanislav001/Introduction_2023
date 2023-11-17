using System.Runtime.CompilerServices;

namespace _01_IntroductionToLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Apples");
            shoppingList.Add("Bananas");
            shoppingList.Add("Milk");

            shoppingList.Insert(1, "Orange");
            shoppingList.Insert(shoppingList.Count, "Pizza");

            shoppingList.Remove("Bananas");
            shoppingList.RemoveAt(1);

            Console.WriteLine("Shopping List:");

            foreach (var item in shoppingList)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}