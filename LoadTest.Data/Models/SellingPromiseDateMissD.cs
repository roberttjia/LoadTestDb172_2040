using System;

namespace LoadTest.Data.Models
{
    public class SellingPromiseDateMissD
    {
        public int SellingPromiseDateMissDId { get; set; }
        public int SellingDId { get; set; }
        public DateTime PromisedDate { get; set; }
        public DateTime ActualDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; }
        public string Notes { get; set; } = string.Empty;

        public virtual SellingD Selling { get; set; } = null!;
    }
}
