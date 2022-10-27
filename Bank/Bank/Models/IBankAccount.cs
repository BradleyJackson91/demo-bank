namespace Bank.Models
{
    public interface IBankAccount
    {
        public string AccountNumber { get; set; }
        public IEmployee OpenedBy { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public bool Active { get; set; }
        public double Balance { get; set; }

    }
}
