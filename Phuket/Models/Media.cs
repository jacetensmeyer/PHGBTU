using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class Media
    {
        public int MediaID { get; set; }
        public string MediaCaption { get; set; }
        public string MediaSummary { get; set; }
        public DateTime MediaEventDate { get; set; }
        public DateTime MediaLastModified { get; set; }
        public bool MediaHighlighted { get; set; }
        public bool MediaActive { get; set; }
        public int MediaCategoryID { get; set; }

        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
        public virtual MediaCategory MediaCategories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}