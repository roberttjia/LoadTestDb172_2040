using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class ProductCatalogTypeD
    {
        public ProductCatalogTypeD()
        {
            ProductCatalog = new HashSet<ProductCatalogD>();
        }

        public int ProductCatalogTypeDId { get; set; }
        public string ProductCatalogTypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public virtual ICollection<ProductCatalogD> ProductCatalog { get; set; }
    }
}
