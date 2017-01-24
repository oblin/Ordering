using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.Models
{
    public partial class Order
    {
        public string ClientId { get; set; }
        public string CompanyName { get; set; }
        public string OrderDate { get; set; }
        public string Stage { get; set; }
        public List<OrderProductVM> Products { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderInstructions { get; set; }
        public string Notes { get; set; }
    }

    [ModelMetadataType(typeof(OrderMeta))]
    public partial class Order
    {

    }

    public class OrderMeta
    {
        [RequiredAttribute(ErrorMessage="The CompanyName is a must")]
        public string CompanyName { get; set; }
        [RequiredAttribute]
        public string OrderDate { get; set; }
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