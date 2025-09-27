using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class SellingListC
    {
        public SellingListC()
        {
            ProductStock = new HashSet<ProductStockC>();
        }

        public int SellingListCId { get; set; }
        public int SellingCId { get; set; }
        public int ProductCId { get; set; }
        public decimal SellingPrice { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
        
        public virtual SellingC Selling { get; set; } = null!;
        public virtual ProductC Product { get; set; } = null!;
        public virtual ICollection<ProductStockC> ProductStock { get; set; }
    }
}
