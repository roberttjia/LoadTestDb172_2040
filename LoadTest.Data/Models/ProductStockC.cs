using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ProductStockC
    {
        public ProductStockC()
        {
            SellingAdjustment = new HashSet<SellingAdjustmentC>();
            ProductLog = new HashSet<ProductLogC>();
            Warranty = new HashSet<WarrantyC>();
        }

        public int ProductStockCId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public int ProductCId { get; set; }
        public int? SellingListId { get; set; }
        public int PurchaseListCId { get; set; }
        public bool IsSold { get; set; }
        
        public virtual ProductC Product { get; set; } = null!;
        public virtual SellingListC? SellingList { get; set; }
        public virtual PurchaseListC PurchaseList { get; set; } = null!;
        public virtual ProductDamagedC? ProductDamaged { get; set; }
        public virtual ICollection<SellingAdjustmentC> SellingAdjustment { get; set; }
        public virtual ICollection<ProductLogC> ProductLog { get; set; }
        public virtual ICollection<WarrantyC> Warranty { get; set; }
    }
}
