using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phuket.Models
{
    public class ContentBlockTag
    {
        public int ContentBlockTagID { get; set; }
        public int ContentBlockID { get; set; }
        public int TagID { get; set; }

        public virtual Tag Tags { get; set; }
        public virtual ContentBlock ContentBlocks { get; set; }
    }
}