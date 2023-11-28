using System;
namespace P02_SimpleGame
{
	public class Hero
	{
		public int Hp { get; set; }

		public string Name { get; set; }

		public double Balance { get; set; }

		public List<Item> Items { get; set; }

		public Hero(int hp, string name, double balance, List<Item> items)
		{
			this.Hp = hp;
			this.Name = name;
			this.Balance = balance;
			this.Items = items;
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

		private void GetInformation()
		{
			Console.WriteLine($"You have ${this.Hp}hp, {this.Balance}$ and ${this.Items.Count()} items");
		}
    }
}

