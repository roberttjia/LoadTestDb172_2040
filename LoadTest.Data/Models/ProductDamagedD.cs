using System;

namespace LoadTest.Data.Models
{
    public class ProductDamagedD
    {
        public int ProductDamagedDId { get; set; }
        public int ProductStockDId { get; set; }
        public string DamageType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DamageDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ProductStockD ProductStockD { get; set; } = null!;
    }
}