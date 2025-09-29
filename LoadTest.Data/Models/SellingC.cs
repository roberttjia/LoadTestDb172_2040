using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class SellingC
    {
        public SellingC()
        {
            SellingAdjustment = new HashSet<SellingAdjustmentC>();
            SellingList = new HashSet<SellingListC>();
            SellingPaymentList = new HashSet<SellingPaymentListC>();
            SellingExpense = new HashSet<SellingExpenseC>();
            Warranty = new HashSet<WarrantyC>();
            ProductLog = new HashSet<ProductLogC>();
            SellingPromiseDateMisses = new HashSet<SellingPromiseDateMissC>();
            SellingPaymentReturnRecord = new HashSet<SellingPaymentReturnRecordC>();
        }

        public int SellingCId { get; set; }
        public int RegistrationCId { get; set; }
        public int CustomerCId { get; set; }
        public int SellingSn { get; set; }
        public decimal SellingTotalPrice { get; set; }
        public decimal SellingDiscountAmount { get; set; }
        public decimal SellingDiscountPercentage { get; set; }
        public decimal SellingPaidAmount { get; set; }
        public decimal SellingReturnAmount { get; set; }
        public decimal SellingDueAmount { get; set; }
        public string SellingPaymentStatus { get; set; } = string.Empty;
        public DateTime SellingDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? PromisedPaymentDate { get; set; }
        public string SellingNotes { get; set; } = string.Empty;
        public decimal ServiceCharge { get; set; }
        public decimal ServiceCost { get; set; }
        public string ServiceChargeDescription { get; set; } = string.Empty;
        public decimal ExpenseTotal { get; set; }
        public decimal AccountTransactionCharge { get; set; }
        public decimal BuyingTotalPrice { get; set; }
        public decimal SellingAccountCost { get; set; }
        public decimal ServiceProfit { get; set; }
        public decimal SellingProfit { get; set; }
        public decimal SellingNetProfit { get; set; }
        public decimal GrandProfit { get; set; }
        public decimal PurchaseAdjustedAmount { get; set; }
        public string PurchaseDescription { get; set; } = string.Empty;
        public int? PurchaseId { get; set; }

        public virtual CustomerC Customer { get; set; } = null!;
        public virtual RegistrationC Registration { get; set; } = null!;
        public virtual PurchaseC? Purchase { get; set; }
        public virtual ICollection<SellingAdjustmentC> SellingAdjustment { get; set; }
        public virtual ICollection<SellingListC> SellingList { get; set; }
        public virtual ICollection<SellingPaymentListC> SellingPaymentList { get; set; }
        public virtual ICollection<SellingExpenseC> SellingExpense { get; set; }
        public virtual ICollection<WarrantyC> Warranty { get; set; }
        public virtual ICollection<ProductLogC> ProductLog { get; set; }
        public virtual ICollection<SellingPromiseDateMissC> SellingPromiseDateMisses { get; set; }
        public virtual ICollection<SellingPaymentReturnRecordC> SellingPaymentReturnRecord { get; set; }
    }
}
