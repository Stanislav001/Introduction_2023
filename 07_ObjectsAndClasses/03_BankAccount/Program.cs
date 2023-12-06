namespace _03_BankAccount;

public class Program
{
    public static void Main()
    {
        Bank bank = new Bank("OBB");

        bank.CreateAccount();
        bank.DepositMoney();
        bank.ShowBankInfo();
    }
}