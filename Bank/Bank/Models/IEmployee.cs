namespace Bank.Models
{
    public interface IEmployee
    {
        public string JobTitle { get; set; }
        public IEmployee LineManager { get; set; }
        public Department Department { get; set; }
    }
}
