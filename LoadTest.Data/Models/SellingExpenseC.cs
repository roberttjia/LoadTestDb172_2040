using System;

namespace LoadTest.Data.Models
{
    public class SellingExpenseC
    {
        public int SellingExpenseCId { get; set; }
        public int SellingCId { get; set; }
        public decimal Expense { get; set; }
        public string ExpenseDescription { get; set; } = string.Empty;
        public DateTime InsertDateUtc { get; set; }
        public int? AccountId { get; set; }

        public virtual SellingC Selling { get; set; } = null!;
        public virtual AccountC? Account { get; set; }
    }
}
