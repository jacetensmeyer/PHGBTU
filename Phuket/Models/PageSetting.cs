using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class PageSetting
    {
        public int PageSettingID { get; set; }
        [StringLength(100)]
        public string PageLayoutSharedView { get; set; }


        public virtual ICollection<Page> Pages { get; set; }
    }
}