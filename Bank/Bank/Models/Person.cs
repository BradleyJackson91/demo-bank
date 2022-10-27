using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<IAddress> AddressHistory { get; set; }
        public List<IEmailAddress> EmailAddresses { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }

    }
}
