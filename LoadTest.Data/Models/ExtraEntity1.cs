using System;

namespace LoadTest.Data.Models
{
    public class ExtraEntity1
    {
        public int ExtraEntity1Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}