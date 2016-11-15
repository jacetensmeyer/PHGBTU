using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class Tag
    {
        public int TagID { get; set; }

        [Required]
        [StringLength(50)]
        public string TagKeyword { get; set; }

        //need to make char(1)
        [StringLength(1)]
        public string TagType { get; set; }


        public virtual ICollection<Media> Medias { get; set; }
        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
    }
}