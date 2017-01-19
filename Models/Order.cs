using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ordering.Models
{
    public class Order
    {
        [Required(ErrorMessage="This is a required field")]
        public string ClientId { get; set; }
        [RequiredAttribute(ErrorMessage="The CompanyName is a must")]
        public string CompanyName { get; set; }
        [RequiredAttribute]
        public string OrderDate { get; set; }
        [RequiredAttribute]
        public string Stage { get; set; }
        public List<OrderProductVM> Products { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderInstructions { get; set; }
        [MaxLengthAttribute(25)]
        public string Notes { get; set; }
    }

    public class OrderProductVM 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
    }

    public class OrderSummary
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Stage { get; set; }
    }
}