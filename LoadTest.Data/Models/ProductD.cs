using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ProductD
    {
        public ProductD()
        {
            ProductStock = new HashSet<ProductStockD>();
            SellingAdjustment = new HashSet<SellingAdjustmentD>();
            PurchaseList = new HashSet<PurchaseListD>();
            SellingList = new HashSet<SellingListD>();
        }

        public int ProductDId { get; set; }
        public int ProductCatalogDId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public decimal SellingPrice { get; set; }
        public DateTime InsertDate { get; set; }
        
        public virtual ProductCatalogD ProductCatalog { get; set; } = null!;
        public virtual ICollection<ProductStockD> ProductStock { get; set; }
        public virtual ICollection<SellingAdjustmentD> SellingAdjustment { get; set; }
        public virtual ICollection<PurchaseListD> PurchaseList { get; set; }
        public virtual ICollection<SellingListD> SellingList { get; set; }
    }
}
