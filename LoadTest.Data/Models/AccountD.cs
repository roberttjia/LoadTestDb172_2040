using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class AccountD
    {
        public AccountD()
        {
            AccountDeposit = new HashSet<AccountDepositD>();
            AccountWithdraw = new HashSet<AccountWithdrawD>();
            SellingPayment = new HashSet<SellingPaymentD>();
            PurchasePayment = new HashSet<PurchasePaymentD>();
            Expense = new HashSet<ExpenseD>();
            ExpenseTransportation = new HashSet<ExpenseTransportationD>();
            SellingPaymentReturnRecord = new HashSet<SellingPaymentReturnRecordD>();
            PurchasePaymentReturnRecord = new HashSet<PurchasePaymentReturnRecordD>();
            SellingExpense = new HashSet<SellingExpenseD>();
        }
        
        public int AccountDId { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public decimal CostPercentage { get; set; }
        
        public virtual InstitutionD? Institution { get; set; }
        public virtual ICollection<AccountWithdrawD> AccountWithdraw { get; set; }
        public virtual ICollection<AccountDepositD> AccountDeposit { get; set; }
        public virtual ICollection<SellingPaymentD> SellingPayment { get; set; }
        public virtual ICollection<PurchasePaymentD> PurchasePayment { get; set; }
        public virtual ICollection<ExpenseD> Expense { get; set; }
        public virtual ICollection<ExpenseTransportationD> ExpenseTransportation { get; set; }
        public virtual ICollection<SellingPaymentReturnRecordD> SellingPaymentReturnRecord { get; set; }
        public virtual ICollection<SellingExpenseD> SellingExpense { get; set; }
        public virtual ICollection<PurchasePaymentReturnRecordD> PurchasePaymentReturnRecord { get; set; }
    }
}
