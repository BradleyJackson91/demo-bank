namespace Bank.Models
{
    public class Employee : Person, IEmployee
    {
        private int Id { get; set; }
        public string JobTitle { get; set; }
        public IEmployee LineManager { get; set; }
        public Department Department { get; set; }

    }
}
