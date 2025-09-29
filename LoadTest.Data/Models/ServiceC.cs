using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public partial class ServiceC
    {
        public ServiceC()
        {
            ServiceList = new HashSet<ServiceListC>();
            ServicePaymentList = new HashSet<ServicePaymentListC>();
        }

        public int ServiceCId { get; set; }
        public int RegistrationCId { get; set; }
        public int CustomerCId { get; set; }
        public int ServiceSn { get; set; }
        public decimal ServiceTotalPrice { get; set; }
        public decimal ServiceDiscountAmount { get; set; }
        public decimal ServiceDiscountPercentage { get; set; }
        public decimal ServicePaidAmount { get; set; }
        public decimal ServiceDueAmount { get; set; }
        public string ServicePaymentStatus { get; set; } = string.Empty;
        public DateTime ServiceDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual CustomerC Customer { get; set; } = null!;
        public virtual RegistrationC Registration { get; set; } = null!;
        public virtual ICollection<ServiceListC> ServiceList { get; set; }
        public virtual ICollection<ServicePaymentListC> ServicePaymentList { get; set; }
    }
}
