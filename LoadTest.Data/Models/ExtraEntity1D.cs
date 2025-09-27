using System;

namespace LoadTest.Data.Models
{
    public class ExtraEntity1D
    {
        public int ExtraEntity1DId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}