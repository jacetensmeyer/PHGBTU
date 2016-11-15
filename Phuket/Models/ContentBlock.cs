
//something
//something else that katie entered
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
        public int ContentBlockID { get; set; }

        [Required]
        [StringLength(100)]
        public string CBHeader { get; set; }
        
        [Required]
        public string CBText { get; set; }

        //needs to be smalldatetime
        public DateTime CBEventDate { get; set; }

        //needs to be smalldatetime
        [Required]
        public DateTime CBLastModified { get; set; }

        [Required]
        public bool CBActive { get; set; }

        [Required]
        public bool CBHighlighted { get; set; }

        //needs to be smallint
        [Required]
        public int ContentBlockCategoryID { get; set; }


        
        public virtual ICollection<Media> Medias { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}