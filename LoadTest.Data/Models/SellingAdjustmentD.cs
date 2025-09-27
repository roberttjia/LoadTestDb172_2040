using System;

namespace LoadTest.Data.Models
{
    public class SellingAdjustmentD
    {
        public int SellingAdjustmentDId { get; set; }
        public int SellingDId { get; set; }
        public int ProductDId { get; set; }
        public int ProductStockDId { get; set; }
        public string AdjustmentType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime AdjustmentDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string ApprovedBy { get; set; } = string.Empty;

        public virtual SellingD Selling { get; set; } = null!;
        public virtual ProductD Product { get; set; } = null!;
        public virtual ProductStockD ProductStock { get; set; } = null!;
    }
}
