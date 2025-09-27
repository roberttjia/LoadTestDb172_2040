using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PurchasePaymentD
    {
        public PurchasePaymentD()
        {
            PurchasePaymentList = new HashSet<PurchasePaymentListD>();
        }

        public int PurchasePaymentDId { get; set; }
        public int VendorDId { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;

        public virtual VendorD Vendor { get; set; } = null!;
        public virtual AccountD? Account { get; set; }
        public virtual ICollection<PurchasePaymentListD> PurchasePaymentList { get; set; }
    }
}
