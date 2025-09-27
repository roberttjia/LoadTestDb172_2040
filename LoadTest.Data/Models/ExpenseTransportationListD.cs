using System;

namespace LoadTest.Data.Models
{
    public class ExpenseTransportationListD
    {
        public int ExpenseTransportationListDId { get; set; }
        public int ExpenseTransportationDId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ExpenseTransportationD ExpenseTransportation { get; set; } = null!;
    }
}
