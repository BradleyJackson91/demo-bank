namespace Bank.Models
{
    public interface IAccountHolder
    {
        public List<IBankAccount> Accounts { get; set; }
    }
}
