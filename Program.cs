

namespace BankAccountManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CheckingAccount c = new CheckingAccount(700.0f);
            double amount;

            System.Console.WriteLine("Please enter an amount: ");
            amount = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine($"Balance: {c.getBalance()}");
            c.withdraw(amount);
            System.Console.WriteLine($"Balance: {c.getBalance()}");

        }
    }
}