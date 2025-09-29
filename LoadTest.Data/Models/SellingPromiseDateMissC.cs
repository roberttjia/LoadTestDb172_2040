using System;

namespace LoadTest.Data.Models
{
    public class SellingPromiseDateMissC
    {
        public int SellingPromiseDateMissCId { get; set; }
        public int SellingCId { get; set; }
        public DateTime PromisedDate { get; set; }
        public DateTime ActualDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; }
        public string Notes { get; set; } = string.Empty;

        public virtual SellingC Selling { get; set; } = null!;
    }
}
