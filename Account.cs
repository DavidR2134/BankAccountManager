namespace BankAccountManager
{
    public abstract class Account
    {
        private double balance;
        
        public Account(){}
        public Account(double balance)
        {
            setBalance(balance);
        }

        protected void setBalance(double balance)
        {
            if (balance > 0)
            {
                this.balance = balance;
            }
            else
            {
                this.balance = -1;
            }
        }

        public double getBalance()
        {
            return this.balance;
        }

        public abstract void withdraw(double balance);
        public abstract void deposit(double amount);

    }
}