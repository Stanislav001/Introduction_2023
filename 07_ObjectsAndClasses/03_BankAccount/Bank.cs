using System;
namespace _03_BankAccount
{
	public class Bank
	{
		public string Name { get; set; }

		public double Balance { get; set; }

		public List<Account> Accounts { get; set; }

		public Bank(string name)
		{
			this.Name = name;
			this.Balance = 1000;
			this.Accounts = new List<Account>();
		}

		public void DepositMoney()
		{
			Console.Write("Enter your PIN code: ");
			string pinCode = Console.ReadLine();

			Account account =  this.Accounts.Find((account) => account.Pin == pinCode);

			if (account != null)
			{
				Console.Write("Enter money: ");
				double money = double.Parse(Console.ReadLine());

				if (CheckMoneyHelper(money))
				{
                    this.Balance += money;
                    account.DepositMoney(money);
                }
			}
			else
			{
				Console.WriteLine("Invalid PIN code!");
			}
		}

        public void WithDrawMoney()
        {
            Console.Write("Enter your PIN code: ");
            string pinCode = Console.ReadLine();

            Account account = this.Accounts.Find((account) => account.Pin == pinCode);

            if (account != null)
            {
                Console.Write("Enter money: ");
                double money = double.Parse(Console.ReadLine());

				if (CheckMoneyHelper(money))
				{
                    if (this.Balance >= money)
					{
                        this.Balance -= money;
                        account.WithDraw(money);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN code!");
            }
        }

        public void CreateAccount()
		{
			Console.Write("Enter name: ");
			string name = Console.ReadLine();

            Console.Write("Enter EGN: ");
            string egn = Console.ReadLine();

            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();

            Account account = new Account(name, egn, pin);
			this.Accounts.Add(account);
		}

		public void ShowBankInfo()
		{
			Console.WriteLine($"Bank name: {this.Name}, {this.Balance}");

			foreach (var account in this.Accounts)
			{
				Console.WriteLine($"{account.Name}, {account.Egn}, {account.Balance}");
			}
		}

		private bool CheckMoneyHelper(double money)
		{
			if (money > 0)
			{
				return true;
			}
			else
			{
				Console.WriteLine("Invalid number!");
				return false;
			}
        }
	}
}