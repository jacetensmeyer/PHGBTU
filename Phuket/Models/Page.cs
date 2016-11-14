using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phuket.Models
{
    public class Page
    {
        public int PageID { get; set; }
        public string PageTitle { get; set; }
        public string PageText { get; set; }
        public DateTime PageLastModified { get; set; }
        public string PageAuthor { get; set; }
        public bool PageActive { get; set; }
        public int? ParentPageID { get; set; }
        public int PageSettingID { get; set; }//does this need to be required?


        public virtual PageSetting Setting { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
    }
}