using System;

namespace LoadTest.Data.Models
{
    public class ExpenseTransportationListC
    {
        public int ExpenseTransportationListCId { get; set; }
        public int ExpenseTransportationCId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual ExpenseTransportationC ExpenseTransportation { get; set; } = null!;
    }
}
