namespace Bank.Models
{
    public interface IEmailAddress
    {
        public string Email { get; set; }
        public bool Primary { get; set; }
    }
}
