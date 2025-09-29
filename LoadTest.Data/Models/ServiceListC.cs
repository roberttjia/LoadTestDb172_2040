using System;

namespace LoadTest.Data.Models
{
    public class ServiceListC
    {
        public int ServiceListCId { get; set; }
        public int ServiceCId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ServiceC Service { get; set; } = null!;
    }
}
