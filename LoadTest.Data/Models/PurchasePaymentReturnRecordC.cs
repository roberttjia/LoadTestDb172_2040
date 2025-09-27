using System;

namespace LoadTest.Data.Models
{
    public class PurchasePaymentReturnRecordC
    {
        public int PurchasePaymentReturnRecordCId { get; set; }
        public int PurchaseCId { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime ReturnDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string ApprovedBy { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public virtual PurchaseC Purchase { get; set; } = null!;
        public virtual AccountC? Account { get; set; }
    }
}
