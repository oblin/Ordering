using System;

namespace Ordering.Models
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? ContactDate { get; set; }
        public string ClientType { get; set; }
        public string Notes { get; set; }

        public Address BillingAddress { get; set; }
        public Address MailingAddress { get; set; }
    }
}