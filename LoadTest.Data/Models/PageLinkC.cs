using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PageLinkC
    {
        public PageLinkC()
        {
            PageLinkAssign = new HashSet<PageLinkAssignC>();
        }

        public int PageLinkCId { get; set; }
        public int PageLinkCategoryCId { get; set; }
        public string PageName { get; set; } = string.Empty;
        public string PageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual PageLinkCategoryC PageLinkCategory { get; set; } = null!;
        public virtual ICollection<PageLinkAssignC> PageLinkAssign { get; set; }
    }
}
