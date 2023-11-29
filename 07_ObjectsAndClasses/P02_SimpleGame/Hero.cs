using System;
namespace P02_SimpleGame
{
	public class Hero
	{
		public int Hp { get; set; }

		public string Name { get; set; }

		public double Balance { get; set; }

		public List<Item> Items { get; set; }

		public Hero(int hp, string name, double balance)
		{
			this.Hp = hp;
			this.Name = name;
			this.Balance = balance;
			this.Items = new List<Item>();
		}

        public void AddItem(Item item)
        {
			this.Balance -= item.Price;
			this.Items.Add(item);

			GetInformation();
        }

		public void DepositMoney(double money)
		{
			this.Balance += money;

			GetInformation();

        }

		public void Attack()
		{
			this.Hp -= 1;

			GetInformation();

        }

		public void GetInformation()
		{
			Console.WriteLine($"You have {this.Hp}hp, {this.Balance}$ and {this.Items.Count()} items");
		}

		public void GetEndInfo()
		{
            Console.WriteLine($"You have {this.Hp}hp, {this.Balance}$ and {this.Items.Count()} items");
			Console.WriteLine("Your items: ");

			foreach (var item in this.Items)
			{
				Console.WriteLine($"{item.Name} <-> {item.Price}");
			}
        }
    }
}

