﻿using System;

namespace LoadTest.Data.Models
{
    public class ProductLogD
    {
        public int ProductLogDId { get; set; }
        public int ProductStockDId { get; set; }
        public int? PurchaseId { get; set; }
        public int? SellingId { get; set; }
        public string Action { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime LogDate { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public virtual ProductStockD ProductStock { get; set; } = null!;
        public virtual PurchaseD? Purchase { get; set; }
        public virtual SellingD? Selling { get; set; }
    }
}
