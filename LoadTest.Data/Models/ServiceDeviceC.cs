using System;

namespace LoadTest.Data.Models
{
    public class ServiceDeviceC
    {
        public int ServiceDeviceCId { get; set; }
        public int CustomerCId { get; set; }
        public string DeviceName { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Problem { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime ReceivedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual CustomerC Customer { get; set; } = null!;
    }
}
