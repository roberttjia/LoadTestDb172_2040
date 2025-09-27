using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class SellingD
    {
        public SellingD()
        {
            SellingAdjustment = new HashSet<SellingAdjustmentD>();
            SellingList = new HashSet<SellingListD>();
            SellingPaymentList = new HashSet<SellingPaymentListD>();
            SellingExpense = new HashSet<SellingExpenseD>();
            Warranty = new HashSet<WarrantyD>();
            ProductLog = new HashSet<ProductLogD>();
            SellingPromiseDateMisses = new HashSet<SellingPromiseDateMissD>();
            SellingPaymentReturnRecord = new HashSet<SellingPaymentReturnRecordD>();
        }

        public int SellingDId { get; set; }
        public int RegistrationDId { get; set; }
        public int CustomerDId { get; set; }
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

        public virtual CustomerD Customer { get; set; } = null!;
        public virtual RegistrationD Registration { get; set; } = null!;
        public virtual PurchaseD? Purchase { get; set; }
        public virtual ICollection<SellingAdjustmentD> SellingAdjustment { get; set; }
        public virtual ICollection<SellingListD> SellingList { get; set; }
        public virtual ICollection<SellingPaymentListD> SellingPaymentList { get; set; }
        public virtual ICollection<SellingExpenseD> SellingExpense { get; set; }
        public virtual ICollection<WarrantyD> Warranty { get; set; }
        public virtual ICollection<ProductLogD> ProductLog { get; set; }
        public virtual ICollection<SellingPromiseDateMissD> SellingPromiseDateMisses { get; set; }
        public virtual ICollection<SellingPaymentReturnRecordD> SellingPaymentReturnRecord { get; set; }
    }
}
