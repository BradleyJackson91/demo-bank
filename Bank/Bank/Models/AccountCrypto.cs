namespace Bank.Models
{
    public class AccountCrypto : BankAccount
    {
        public CryptoCurrencyLKP CryptoCurrency { get; set; }

        public bool BuyCurrency()
        {
            throw new NotImplementedException();
        }
        public bool SellCurrency()
        {
            throw new NotImplementedException();
        }
        public bool Transfer()
        {
            throw new NotImplementedException();
        }
    }
}
