using System;

namespace LoadTest.Data.Models
{
    public class ServicePaymentListC
    {
        public int ServicePaymentListCId { get; set; }
        public int ServiceCId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ServiceC Service { get; set; } = null!;
    }
}
