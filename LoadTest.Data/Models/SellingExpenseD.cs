using System;

namespace LoadTest.Data.Models
{
    public class SellingExpenseD
    {
        public int SellingExpenseDId { get; set; }
        public int SellingDId { get; set; }
        public decimal Expense { get; set; }
        public string ExpenseDescription { get; set; } = string.Empty;
        public DateTime InsertDateUtc { get; set; }
        public int? AccountId { get; set; }

        public virtual SellingD Selling { get; set; } = null!;
        public virtual AccountD? Account { get; set; }
    }
}
