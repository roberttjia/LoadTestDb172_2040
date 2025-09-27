using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class ExpenseCategoryD
    {
        public ExpenseCategoryD()
        {
            Expense = new HashSet<ExpenseD>();
        }

        public int ExpenseCategoryDId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<ExpenseD> Expense { get; set; }
    }
}
