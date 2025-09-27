using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class ProductCatalogD
    {
        public ProductCatalogD()
        {
            Product = new HashSet<ProductD>();
        }

        public int ProductCatalogDId { get; set; }
        public int ProductCatalogTypeDId { get; set; }
        public string ProductCatalogName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Specification { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public string Color { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ProductCatalogTypeD ProductCatalogType { get; set; } = null!;
        public virtual ICollection<ProductD> Product { get; set; }
    }
}
