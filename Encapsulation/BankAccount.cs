namespace OOP.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal amount)
        {
            Deposit(amount);
        }

        public decimal GetBalance() 
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }

            if (amount > _balance)
            {
                throw new ArgumentException("Insufficients fund");
            }
            _balance -= amount;
        }
    }
}
