using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Web.Models.Catalogs
{
    public class FeatureViewModel
    {
        [Display(Name = "Kurs süresi")]
        public int Duration { get; set; }
    }
}
