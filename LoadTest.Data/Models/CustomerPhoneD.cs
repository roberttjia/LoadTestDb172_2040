using System;

namespace LoadTest.Data.Models
{
    public class CustomerPhoneD
    {
        public int CustomerPhoneDId { get; set; }
        public int CustomerDId { get; set; }
        public string Phone { get; set; } = string.Empty;
        public bool? IsPrimary { get; set; }
        public DateTime InsertDate { get; set; }
        
        public virtual CustomerD Customer { get; set; } = null!;
    }
}
