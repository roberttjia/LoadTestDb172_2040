using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class SellingListD
    {
        public SellingListD()
        {
            ProductStock = new HashSet<ProductStockD>();
        }

        public int SellingListDId { get; set; }
        public int SellingDId { get; set; }
        public int ProductDId { get; set; }
        public decimal SellingPrice { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
        
        public virtual SellingD Selling { get; set; } = null!;
        public virtual ProductD Product { get; set; } = null!;
        public virtual ICollection<ProductStockD> ProductStock { get; set; }
    }
}
