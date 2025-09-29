using System;

namespace LoadTest.Data.Models
{
    public class SellingAdjustmentC
    {
        public int SellingAdjustmentCId { get; set; }
        public int SellingCId { get; set; }
        public int ProductCId { get; set; }
        public int ProductStockCId { get; set; }
        public string AdjustmentType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime AdjustmentDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string ApprovedBy { get; set; } = string.Empty;

        public virtual SellingC Selling { get; set; } = null!;
        public virtual ProductC Product { get; set; } = null!;
        public virtual ProductStockC ProductStock { get; set; } = null!;
    }
}
