namespace Bank.Models
{
    public interface IBankCard
    {
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public string CSV { get; set; }
        public string PIN { get; set; }
        public bool Active { get; set; }
        public bool Locked { get; set; }

        public bool ActivateCard();
        public bool LockCard();
        public bool CheckPin(string pPIn);
    }
}
