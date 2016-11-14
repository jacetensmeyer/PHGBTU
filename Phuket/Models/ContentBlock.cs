
//something
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class ContentBlock
    {
        public int CBID { get; set; }
        public string CBHeader { get; set; }
        public string CBText { get; set; }
        public DateTime CBEventDate { get; set; }
        public DateTime CBLastModified { get; set; }
        public bool CBActive { get; set; }
        public bool CBHighlighted { get; set; }
        public int CBCategoryID { get; set; }
        
        public virtual ICollection<Media> Medias { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}