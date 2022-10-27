namespace Bank.Models
{
    public class EmailAddress : IEmailAddress
    {
        private int Id { get; set; }
        public string Email { get; set; }
        public bool Primary { get; set; }
    }
}
