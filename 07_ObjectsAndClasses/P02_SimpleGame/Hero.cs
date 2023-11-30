using System;
namespace P02_SimpleGame
{
	public class Hero
	{
		private const int START_HERO_HP = 10;
		private const int START_HERO_BALANCE = 10;

        public int Hp { get; set; }

		public string Name { get; set; }

		public double Balance { get; set; }

		public List<Item> Items { get; set; }

		public Hero(string name)
		{
			this.Name = name;
			this.Hp = START_HERO_HP;
			this.Items = new List<Item>();
			this.Balance = START_HERO_BALANCE;
		}

        public void AddItem(Item item)
        {
			this.Balance -= item.Price;
			this.Items.Add(item);

            GetInformationHelper();
        }

		public void DepositMoney(double money)
		{
			this.Balance += money;

            GetInformationHelper();
        }

		public void Attack()
		{
			this.Hp -= 1;

            GetInformationHelper();
        }

		private void GetInformationHelper()
		{
			Console.WriteLine($"You have {this.Hp}hp, {this.Balance}$ and {this.Items.Count()} items");
		}

		public void GetInformation()
		{
			GetInformationHelper();
			Console.WriteLine("Your items: ");

			foreach (var item in this.Items)
			{
				Console.WriteLine($"{item.Name} <-> {item.Price}");
			}
        }
    }
}

