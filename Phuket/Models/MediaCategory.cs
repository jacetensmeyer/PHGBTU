using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class MediaCategory
    {
        //needs to be smallint
        public int MediaCategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string MediaCategoryDescription { get; set; }

        [Required]
        [StringLength(4)]
        public string MediaCategoryExtension { get; set; }

        //needs to be smallint
        public int MediaCategoryMaxHeight { get; set; }

        //neds to be smallint
        public int MediaCategoryMaxWidth { get; set; }

        public virtual ICollection<Media> Medias { get; set; }
    }
}