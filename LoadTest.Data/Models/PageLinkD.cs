using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PageLinkD
    {
        public PageLinkD()
        {
            PageLinkAssign = new HashSet<PageLinkAssignD>();
        }

        public int PageLinkDId { get; set; }
        public int PageLinkCategoryDId { get; set; }
        public string PageName { get; set; } = string.Empty;
        public string PageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual PageLinkCategoryD PageLinkCategory { get; set; } = null!;
        public virtual ICollection<PageLinkAssignD> PageLinkAssign { get; set; }
    }
}
