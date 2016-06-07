using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt.Models
{
    public class SearchModel
    {
        

        [Required]
        [Display(Name = "Z:")]
        public string from { get; set; }

        [Required]
        [Display(Name = "Do:")]
        public string to { get; set; }

        [Required]
        [Display(Name = "Data Wylotu")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime flyDate { get; set; }
    }
}