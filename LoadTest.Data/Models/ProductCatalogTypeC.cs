using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class ProductCatalogTypeC
    {
        public ProductCatalogTypeC()
        {
            ProductCatalog = new HashSet<ProductCatalogC>();
        }

        public int ProductCatalogTypeCId { get; set; }
        public string ProductCatalogTypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public virtual ICollection<ProductCatalogC> ProductCatalog { get; set; }
    }
}
