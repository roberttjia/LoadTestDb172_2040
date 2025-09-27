using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class SellingPaymentD
    {
        public SellingPaymentD()
        {
            SellingPaymentList = new HashSet<SellingPaymentListD>();
        }

        public int SellingPaymentDId { get; set; }
        public int CustomerDId { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal ServiceCharge { get; set; }
        public string Receipt { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string CheckNumber { get; set; } = string.Empty;

        public virtual CustomerD Customer { get; set; } = null!;
        public virtual AccountD? Account { get; set; }
        public virtual ICollection<SellingPaymentListD> SellingPaymentList { get; set; }
    }
}
