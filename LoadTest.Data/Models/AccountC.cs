using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class AccountC
    {
        public AccountC()
        {
            AccountDeposit = new HashSet<AccountDepositC>();
            AccountWithdraw = new HashSet<AccountWithdrawC>();
            SellingPayment = new HashSet<SellingPaymentC>();
            PurchasePayment = new HashSet<PurchasePaymentC>();
            Expense = new HashSet<ExpenseC>();
            ExpenseTransportation = new HashSet<ExpenseTransportationC>();
            SellingPaymentReturnRecord = new HashSet<SellingPaymentReturnRecordC>();
            PurchasePaymentReturnRecord = new HashSet<PurchasePaymentReturnRecordC>();
            SellingExpense = new HashSet<SellingExpenseC>();
        }
        
        public int AccountCId { get; set; }
        public string AccountName { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public decimal CostPercentage { get; set; }
        
        public virtual InstitutionC? Institution { get; set; }
        public virtual ICollection<AccountWithdrawC> AccountWithdraw { get; set; }
        public virtual ICollection<AccountDepositC> AccountDeposit { get; set; }
        public virtual ICollection<SellingPaymentC> SellingPayment { get; set; }
        public virtual ICollection<PurchasePaymentC> PurchasePayment { get; set; }
        public virtual ICollection<ExpenseC> Expense { get; set; }
        public virtual ICollection<ExpenseTransportationC> ExpenseTransportation { get; set; }
        public virtual ICollection<SellingPaymentReturnRecordC> SellingPaymentReturnRecord { get; set; }
        public virtual ICollection<SellingExpenseC> SellingExpense { get; set; }
        public virtual ICollection<PurchasePaymentReturnRecordC> PurchasePaymentReturnRecord { get; set; }
    }
}
