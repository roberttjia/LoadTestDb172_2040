using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class CustomerD
    {
        public CustomerD()
        {
            Selling = new HashSet<SellingD>();
            SellingPayment = new HashSet<SellingPaymentD>();
            Service = new HashSet<ServiceD>();
            ServiceDevice = new HashSet<ServiceDeviceD>();
            ExpenseTransportation = new HashSet<ExpenseTransportationD>();
            CustomerPhone = new HashSet<CustomerPhoneD>();
        }

        public int CustomerDId { get; set; }
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
        
        public virtual ICollection<SellingD> Selling { get; set; }
        public virtual ICollection<SellingPaymentD> SellingPayment { get; set; }
        public virtual ICollection<ServiceD> Service { get; set; }
        public virtual ICollection<ServiceDeviceD> ServiceDevice { get; set; }
        public virtual ICollection<CustomerPhoneD> CustomerPhone { get; set; }
        public virtual ICollection<ExpenseTransportationD> ExpenseTransportation { get; set; }
    }
}
