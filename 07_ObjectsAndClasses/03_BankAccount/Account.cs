using System;
namespace _03_BankAccount
{
	public class Account
	{
		public string Name { get; set; }

		public string Pin { get; set; }

		public string Egn { get; set; }

		public double Balance { get; set; }

		public Account(string name, string egn, string pin)
		{
			this.Egn = egn;
			this.Pin = pin;
			this.Balance = 0;
			this.Name = name;
		}

		public void DepositMoney(double money)
		{
			this.Balance += money;
			Console.WriteLine($"You add {money} to your bank account.");
		}

        public void WithDraw(double money)
        {
			if (this.Balance >= money)
			{
                this.Balance -= money;
                Console.WriteLine($"You draw {money} from your bank account.");
            }
        }

		public void Information()
		{
			Console.WriteLine($"{this.Name}, {this.Egn}, {this.Balance}");
		}
    }
}