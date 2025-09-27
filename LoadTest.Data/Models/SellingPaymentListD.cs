using System;

namespace LoadTest.Data.Models
{
    public class SellingPaymentListD
    {
        public int SellingPaymentListDId { get; set; }
        public int SellingPaymentDId { get; set; }
        public int SellingDId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual SellingPaymentD SellingPayment { get; set; } = null!;
        public virtual SellingD Selling { get; set; } = null!;
    }
}
