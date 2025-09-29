using System;

namespace LoadTest.Data.Models
{
    public class PurchasePaymentListC
    {
        public int PurchasePaymentListCId { get; set; }
        public int PurchasePaymentCId { get; set; }
        public int PurchaseCId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; }

        public virtual PurchasePaymentC PurchasePayment { get; set; } = null!;
        public virtual PurchaseC Purchase { get; set; } = null!;
    }
}
