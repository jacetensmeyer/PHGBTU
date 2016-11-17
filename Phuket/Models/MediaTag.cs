using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phuket.Models
{
    public class MediaTag
    {
        public int MediaTagID { get; set; }
        public int TagID { get; set; }
        public int MediaID { get; set; }

        public virtual Media Medias { get; set; }
        public virtual Tag Tags { get; set; }
    }
}