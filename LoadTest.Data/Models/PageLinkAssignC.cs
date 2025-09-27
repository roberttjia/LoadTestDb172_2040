using System;

namespace LoadTest.Data.Models
{
    public class PageLinkAssignC
    {
        public int PageLinkAssignCId { get; set; }
        public int PageLinkCId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public bool CanView { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual PageLinkC PageLink { get; set; } = null!;
    }
}
