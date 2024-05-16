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

        public override void withdraw(double balance)
        {
            throw new NotImplementedException();
        }

        public override void deposit(double amount)
        {
            throw new NotImplementedException();
        }
    }
}