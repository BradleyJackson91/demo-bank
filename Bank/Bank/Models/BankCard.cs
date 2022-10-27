namespace Bank.Models
{
    public class BankCard : IBankCard
    {
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public string CSV { get; set; }
        public string PIN { get; set; }
        public bool Active { get; set; }
        public bool Locked { get; set; }

        public bool ActivateCard()
        {
            throw new NotImplementedException();
        }
        public bool LockCard()
        {
            throw new NotImplementedException();
        }
        public bool CheckPin(string pPIn)
        {
            throw new NotImplementedException();
        }
    }
}
