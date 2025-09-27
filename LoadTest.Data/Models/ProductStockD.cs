using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ProductStockD
    {
        public ProductStockD()
        {
            SellingAdjustment = new HashSet<SellingAdjustmentD>();
            ProductLog = new HashSet<ProductLogD>();
            Warranty = new HashSet<WarrantyD>();
        }

        public int ProductStockDId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public int ProductDId { get; set; }
        public int? SellingListId { get; set; }
        public int PurchaseListDId { get; set; }
        public bool IsSold { get; set; }
        
        public virtual ProductD Product { get; set; } = null!;
        public virtual SellingListD? SellingList { get; set; }
        public virtual PurchaseListD PurchaseList { get; set; } = null!;
        public virtual ProductDamagedD? ProductDamaged { get; set; }
        public virtual ICollection<SellingAdjustmentD> SellingAdjustment { get; set; }
        public virtual ICollection<ProductLogD> ProductLog { get; set; }
        public virtual ICollection<WarrantyD> Warranty { get; set; }
    }
}
