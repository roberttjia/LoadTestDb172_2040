using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class CustomerC
    {
        public CustomerC()
        {
            Selling = new HashSet<SellingC>();
            SellingPayment = new HashSet<SellingPaymentC>();
            Service = new HashSet<ServiceC>();
            ServiceDevice = new HashSet<ServiceDeviceC>();
            ExpenseTransportation = new HashSet<ExpenseTransportationC>();
            CustomerPhone = new HashSet<CustomerPhoneC>();
        }

        public int CustomerCId { get; set; }
        public string OrganizationName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal ReturnAmount { get; set; }
        public decimal Paid { get; set; }
        public decimal AccountTransactionCharge { get; set; }
        public decimal Due { get; set; }
        public decimal PurchaseAdjustedAmount { get; set; }
        public decimal DueLimit { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime InsertDate { get; set; }
        public string Designation { get; set; } = string.Empty;
        public bool IsIndividual { get; set; }
        
        public virtual ICollection<SellingC> Selling { get; set; }
        public virtual ICollection<SellingPaymentC> SellingPayment { get; set; }
        public virtual ICollection<ServiceC> Service { get; set; }
        public virtual ICollection<ServiceDeviceC> ServiceDevice { get; set; }
        public virtual ICollection<CustomerPhoneC> CustomerPhone { get; set; }
        public virtual ICollection<ExpenseTransportationC> ExpenseTransportation { get; set; }
    }
}
