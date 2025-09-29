using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PageLinkCategoryC
    {
        public PageLinkCategoryC()
        {
            PageLink = new HashSet<PageLinkC>();
        }

        public int PageLinkCategoryCId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PageLinkC> PageLink { get; set; }
    }
}
