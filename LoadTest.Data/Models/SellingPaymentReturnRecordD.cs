using System;

namespace LoadTest.Data.Models
{
    public class SellingPaymentReturnRecordD
    {
        public int SellingPaymentReturnRecordDId { get; set; }
        public int SellingDId { get; set; }
        public int? AccountDId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime ReturnDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string ApprovedBy { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public virtual SellingD SellingD { get; set; } = null!;
        public virtual AccountD? AccountD { get; set; }
    }
}