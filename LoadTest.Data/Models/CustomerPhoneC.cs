using System;

namespace LoadTest.Data.Models
{
    public class CustomerPhoneC
    {
        public int CustomerPhoneCId { get; set; }
        public int CustomerCId { get; set; }
        public string Phone { get; set; } = string.Empty;
        public bool? IsPrimary { get; set; }
        public DateTime InsertDate { get; set; }
        
        public virtual CustomerC Customer { get; set; } = null!;
    }
}
