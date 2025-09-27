using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PurchaseListD
    {
        public PurchaseListD()
        {
            ProductStock = new HashSet<ProductStockD>();
        }
        
        public int PurchaseListDId { get; set; }
        public int PurchaseDId { get; set; }
        public int ProductDId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public decimal SellingPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        
        public virtual PurchaseD Purchase { get; set; } = null!;
        public virtual ProductD Product { get; set; } = null!;
        public virtual ICollection<ProductStockD> ProductStock { get; set; }
    }
}
