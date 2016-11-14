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
        public int MediaCategoryID { get; set; }
        public string MediaCategoryDescription { get; set; }
        public string MediaCategoryExtension { get; set; }
        public int MediaCategoryMaxHeight { get; set; }
        public int MediaCategoryMaxWidth { get; set; }

        public virtual ICollection<Media> Medias { get; set; }
    }
}