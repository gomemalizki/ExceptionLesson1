namespace Lesson2
{
    internal class BankAccount
    {
        public int accountId { get; init; }
        public int Balance { get; private set; }
        public BankAccount(int accountId, int initalBalance)
        {
            this.accountId = accountId;
            if (initalBalance < 0)
            {
                throw new ArgumentOutOfRangeException("initual balance cannot be negative");
            }
            if (accountId <= 0) { }
            throw new ArgumentException();
            }

        public void Deposit(int amount)
        {
            this.Balance += amount;
        }

        public OperationResult WithDraw(int amount) {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Withdraw amount cannot be negative");
            }
            if (Balance < amount)
            {
                return false;
            }
            else
                this.Balance += amount;
            return true;  צילמתי פה תמונה בשעה 16:57 במקום מה שכתוב
        }
}   }
