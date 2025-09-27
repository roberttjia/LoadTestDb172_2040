using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ServiceD
    {
        public ServiceD()
        {
            ServiceList = new HashSet<ServiceListD>();
            ServicePaymentList = new HashSet<ServicePaymentListD>();
        }

        public int ServiceDId { get; set; }
        public int RegistrationDId { get; set; }
        public int CustomerDId { get; set; }
        public int ServiceSn { get; set; }
        public decimal ServiceTotalPrice { get; set; }
        public decimal ServiceDiscountAmount { get; set; }
        public decimal ServiceDiscountPercentage { get; set; }
        public decimal ServicePaidAmount { get; set; }
        public decimal ServiceDueAmount { get; set; }
        public string ServicePaymentStatus { get; set; } = string.Empty;
        public DateTime ServiceDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual CustomerD Customer { get; set; } = null!;
        public virtual RegistrationD Registration { get; set; } = null!;
        public virtual ICollection<ServiceListD> ServiceList { get; set; }
        public virtual ICollection<ServicePaymentListD> ServicePaymentList { get; set; }
    }
}
