using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Models
{
    public class CompanyAddViewModel
    {
        public int NumberOfCharsInName { get; set; }
        public int NumberOfCharsInDescription { get; set; }
        public bool isHidden { get; set; }
    }
}
