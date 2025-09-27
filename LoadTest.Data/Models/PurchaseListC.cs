using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PurchaseListC
    {
        public PurchaseListC()
        {
            ProductStock = new HashSet<ProductStockC>();
        }
        
        public int PurchaseListCId { get; set; }
        public int PurchaseCId { get; set; }
        public int ProductCId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Warranty { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public decimal SellingPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        
        public virtual PurchaseC Purchase { get; set; } = null!;
        public virtual ProductC Product { get; set; } = null!;
        public virtual ICollection<ProductStockC> ProductStock { get; set; }
    }
}
