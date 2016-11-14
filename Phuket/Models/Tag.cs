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
        public string TagKeyword { get; set; }
        public string TagType { get; set; }

        public virtual ICollection<Media> MediaItems { get; set; }
    }
}