using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phuket.Models
{
    public class ContentBlockCategory
    {
        public int CBCategoryID { get; set; }
        public string CBCategory { get; set; }

        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
    }
}