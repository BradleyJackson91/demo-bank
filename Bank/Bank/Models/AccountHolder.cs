namespace Bank.Models
{
    public class AccountHolder : Person, IAccountHolder
    {
        private int Id { get; set; }
        public List<IBankAccount> Accounts { get; set; }

    }
}
