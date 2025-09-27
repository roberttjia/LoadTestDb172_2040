using System;

namespace LoadTest.Data.Models
{
    public class ServiceDeviceD
    {
        public int ServiceDeviceDId { get; set; }
        public int CustomerDId { get; set; }
        public string DeviceName { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Problem { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime ReceivedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual CustomerD Customer { get; set; } = null!;
    }
}
