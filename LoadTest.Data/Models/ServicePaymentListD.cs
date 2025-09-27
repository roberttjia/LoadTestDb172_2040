using System;

namespace LoadTest.Data.Models
{
    public class ServicePaymentListD
    {
        public int ServicePaymentListDId { get; set; }
        public int ServiceDId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ServiceD Service { get; set; } = null!;
    }
}
