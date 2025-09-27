using System;

namespace LoadTest.Data.Models
{
    public class PurchasePaymentListD
    {
        public int PurchasePaymentListDId { get; set; }
        public int PurchasePaymentDId { get; set; }
        public int PurchaseDId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; }

        public virtual PurchasePaymentD PurchasePayment { get; set; } = null!;
        public virtual PurchaseD Purchase { get; set; } = null!;
    }
}
