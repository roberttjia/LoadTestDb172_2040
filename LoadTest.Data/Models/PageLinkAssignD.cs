using System;

namespace LoadTest.Data.Models
{
    public class PageLinkAssignD
    {
        public int PageLinkAssignDId { get; set; }
        public int PageLinkDId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public bool CanView { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual PageLinkD PageLink { get; set; } = null!;
    }
}
