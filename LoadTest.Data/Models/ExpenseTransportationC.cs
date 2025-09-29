using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class ExpenseTransportationC
    {
        public ExpenseTransportationC()
        {
            ExpenseTransportationList = new HashSet<ExpenseTransportationListC>();
        }

        public int ExpenseTransportationCId { get; set; }
        public int CustomerCId { get; set; }
        public int? AccountId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime TransportationDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string VehicleType { get; set; } = string.Empty;
        public string Route { get; set; } = string.Empty;
        public decimal Distance { get; set; }
        public string DriverName { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public virtual CustomerC Customer { get; set; } = null!;
        public virtual AccountC? Account { get; set; }
        public virtual ICollection<ExpenseTransportationListC> ExpenseTransportationList { get; set; }
    }
}
