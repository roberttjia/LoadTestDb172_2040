using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class PurchaseD
    {
        public PurchaseD()
        {
            PurchaseList = new HashSet<PurchaseListD>();
            PurchasePaymentList = new HashSet<PurchasePaymentListD>();
            ProductLog = new HashSet<ProductLogD>();
            PurchasePaymentReturnRecord = new HashSet<PurchasePaymentReturnRecordD>();
        }

        public int PurchaseDId { get; set; }
        public int RegistrationDId { get; set; }
        public int VendorDId { get; set; }
        public int PurchaseSn { get; set; }
        public decimal PurchaseTotalPrice { get; set; }
        public decimal PurchaseDiscountAmount { get; set; }
        public decimal PurchaseDiscountPercentage { get; set; }
        public decimal PurchasePaidAmount { get; set; }
        public decimal PurchaseReturnAmount { get; set; }
        public decimal PurchaseDueAmount { get; set; }
        public string PurchasePaymentStatus { get; set; } = string.Empty;
        public string MemoNumber { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual RegistrationD Registration { get; set; } = null!;
        public virtual VendorD Vendor { get; set; } = null!;
        public virtual SellingD? Selling { get; set; }
        public virtual ICollection<PurchaseListD> PurchaseList { get; set; }
        public virtual ICollection<PurchasePaymentListD> PurchasePaymentList { get; set; }
        public virtual ICollection<ProductLogD> ProductLog { get; set; }
        public virtual ICollection<PurchasePaymentReturnRecordD> PurchasePaymentReturnRecord { get; set; }
    }
}
