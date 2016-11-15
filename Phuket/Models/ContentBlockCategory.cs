using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class ContentBlockCategory
    {
        //needs to be smallint
        public int ContentBlockCategoryID { get; set; }

        [Required]
        [StringLength(25)]
        public string CBCategory { get; set; }



        public virtual ICollection<ContentBlock> ContentBlocks { get; set; }
    }
}