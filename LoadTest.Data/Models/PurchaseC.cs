using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class PurchaseC
    {
        public PurchaseC()
        {
            PurchaseList = new HashSet<PurchaseListC>();
            PurchasePaymentList = new HashSet<PurchasePaymentListC>();
            ProductLog = new HashSet<ProductLogC>();
            PurchasePaymentReturnRecord = new HashSet<PurchasePaymentReturnRecordC>();
        }

        public int PurchaseCId { get; set; }
        public int RegistrationCId { get; set; }
        public int VendorCId { get; set; }
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

        public virtual RegistrationC Registration { get; set; } = null!;
        public virtual VendorC Vendor { get; set; } = null!;
        public virtual SellingC? Selling { get; set; }
        public virtual ICollection<PurchaseListC> PurchaseList { get; set; }
        public virtual ICollection<PurchasePaymentListC> PurchasePaymentList { get; set; }
        public virtual ICollection<ProductLogC> ProductLog { get; set; }
        public virtual ICollection<PurchasePaymentReturnRecordC> PurchasePaymentReturnRecord { get; set; }
    }
}
