namespace Bank.Models
{
    public class BankAccount : IBankAccount
    {
        private int Id { get; set; }
        public string AccountNumber { get; set; }
        public IEmployee OpenedBy { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public bool Active { get; set; }
        public double Balance { get; set; }
    }
}
