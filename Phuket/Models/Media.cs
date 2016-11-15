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

        [Required]
        [StringLength(50)]
        public string MediaCaption { get; set; }
        
        [Required]
        public string MediaSummary { get; set; }

        //needs to be smalldatetime
        public DateTime MediaEventDate { get; set; }

        //needs to be smalldatetime
        [Required]
        public DateTime MediaLastModified { get; set; }

        [Required]
        public bool MediaHighlighted { get; set; }

        [Required]
        public bool MediaActive { get; set; }

        //needs to be smallint
        [Required]
        public int MediaCategoryID { get; set; }

        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
        public virtual MediaCategory MediaCategories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}