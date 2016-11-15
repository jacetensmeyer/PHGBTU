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

        [StringLength(100)]
        public string PageTitle { get; set; }
        
        public string PageText { get; set; }

        //needs to be smalldatetime
        public DateTime PageLastModified { get; set; }

        [StringLength(100)]
        public string PageAuthor { get; set; }

        public bool PageActive { get; set; }

        //public int? ParentPageID { get; set; } //don't know how to do heirarchy relationship

        //needs to be smallint
        public int PageSettingID { get; set; }//does this need to be required?




        public virtual PageSetting PageSetting { get; set; }
        //public virtual ICollection<Page> Pages { get; set; }
    }
}