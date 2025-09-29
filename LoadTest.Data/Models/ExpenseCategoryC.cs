using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class ExpenseCategoryC
    {
        public ExpenseCategoryC()
        {
            Expense = new HashSet<ExpenseC>();
        }

        public int ExpenseCategoryCId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<ExpenseC> Expense { get; set; }
    }
}
