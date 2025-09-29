using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ProductC
    {
        public ProductC()
        {
            ProductStock = new HashSet<ProductStockC>();
            SellingAdjustment = new HashSet<SellingAdjustmentC>();
            PurchaseList = new HashSet<PurchaseListC>();
            SellingList = new HashSet<SellingListC>();
        }

        public int ProductCId { get; set; }
        public int ProductCatalogCId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public decimal SellingPrice { get; set; }
        public DateTime InsertDate { get; set; }
        
        public virtual ProductCatalogC ProductCatalog { get; set; } = null!;
        public virtual ICollection<ProductStockC> ProductStock { get; set; }
        public virtual ICollection<SellingAdjustmentC> SellingAdjustment { get; set; }
        public virtual ICollection<PurchaseListC> PurchaseList { get; set; }
        public virtual ICollection<SellingListC> SellingList { get; set; }
    }
}
