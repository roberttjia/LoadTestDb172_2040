using System;

namespace LoadTest.Data.Models
{
    public class ProductDamagedC
    {
        public int ProductDamagedCId { get; set; }
        public int ProductStockCId { get; set; }
        public string DamageType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DamageDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ProductStockC ProductStock { get; set; } = null!;
    }
}
