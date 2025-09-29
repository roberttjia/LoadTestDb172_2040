using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PurchasePaymentC
    {
        public PurchasePaymentC()
        {
            PurchasePaymentList = new HashSet<PurchasePaymentListC>();
        }

        public int PurchasePaymentCId { get; set; }
        public int VendorCId { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;

        public virtual VendorC Vendor { get; set; } = null!;
        public virtual AccountC? Account { get; set; }
        public virtual ICollection<PurchasePaymentListC> PurchasePaymentList { get; set; }
    }
}
