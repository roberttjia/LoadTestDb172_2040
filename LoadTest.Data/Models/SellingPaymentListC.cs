using System;

namespace LoadTest.Data.Models
{
    public class SellingPaymentListC
    {
        public int SellingPaymentListCId { get; set; }
        public int SellingPaymentCId { get; set; }
        public int SellingCId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual SellingPaymentC SellingPayment { get; set; } = null!;
        public virtual SellingC Selling { get; set; } = null!;
    }
}
