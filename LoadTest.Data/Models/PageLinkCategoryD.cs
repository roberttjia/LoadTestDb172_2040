using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PageLinkCategoryD
    {
        public PageLinkCategoryD()
        {
            PageLink = new HashSet<PageLinkD>();
        }

        public int PageLinkCategoryDId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PageLinkD> PageLink { get; set; }
    }
}
