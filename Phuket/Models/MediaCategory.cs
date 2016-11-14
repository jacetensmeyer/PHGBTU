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
        public string MediaCategoryType { get; set; }

        public virtual ICollection<Media> MediaItems { get; set; }
    }
}