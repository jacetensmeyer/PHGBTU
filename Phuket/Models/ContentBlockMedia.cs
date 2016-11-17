using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phuket.Models
{
    public class ContentBlockMedia
    {
        public int ContentBlockMediaID { get; set; }
        public int ContentBlockID { get; set; }
        public int MediaID { get; set; }
        
        public virtual Media Media { get; set; }
        public virtual ContentBlock ContentBlock { get; set; }
    }
}