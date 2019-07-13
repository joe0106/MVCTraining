using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW.Models.ViewModels
{
    public class RecordsViewModel
    {
        [Display(Name = "類別")]
        public string Category { get; set; }

        [Display(Name = "價格")]
        public int Price { get; set; }

        [Display(Name = "日期")]
        public DateTime BuyDate { get; set; }

        [Display(Name = "備註")]
        public string Remarks { get; set; }
    }
}