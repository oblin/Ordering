using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.Models
{
    public class Client
    {
        // [Required]
        public string FirstName { get; set; }
        // [Required]
        public string LastName { get; set; }
        // [Required]
        public string CompanyName { get; set; }
        // [Required, EmailAddress]
        // [Remote("VerifyEmail", "Client")]
        public string Email { get; set; }
        // [Required]
        public string Phone { get; set; }
        public DateTime? ContactDate { get; set; }
        // [Required]
        public string ClientType { get; set; }
        public string NearestLocation { get; set; }
        [MaxLengthAttribute(25)]
        public string Notes { get; set; }

        public List<EmailPromo> EmailPromos { get; set; }

        public Address BillingAddress { get; set; }
        public Address MailingAddress { get; set; }
    }
}