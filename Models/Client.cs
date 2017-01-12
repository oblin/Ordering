using System;
using System.ComponentModel.DataAnnotations;

namespace Ordering.Models
{
    public class Client
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public DateTime? ContactDate { get; set; }
        [Required]
        public string ClientType { get; set; }
        [MaxLengthAttribute(25)]
        public string Notes { get; set; }

        public Address BillingAddress { get; set; }
        public Address MailingAddress { get; set; }
    }
}