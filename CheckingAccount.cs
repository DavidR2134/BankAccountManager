using System.Formats.Asn1;
using System.Runtime;

namespace BankAccountManager
{
    public class CheckingAccount : Account
    {
        public CheckingAccount()
        {}
        
        public CheckingAccount(double balance)
        {
            setBalance(balance);
        }

        public override void withdraw(double amount)
        {
            if(amount < 0)
            {
                System.Console.WriteLine("Please enter an amount greater than 0.");
            }
            else if (this.getBalance() > 0 && amount > 0)
            {
                double newBalance = this.getBalance() - amount;
                setBalance(newBalance);
                System.Console.WriteLine($"New balance: {this.getBalance()}");
            }
            else
            {
                System.Console.WriteLine("Insufficient funds");
            }
        }

        public override void deposit(double amount)
        {
            throw new NotImplementedException();
        }
    }
}