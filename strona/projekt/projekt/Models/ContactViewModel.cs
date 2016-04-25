using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace projekt.Models
{
    public class ContactViewModel
    {
        [Required, Display(Name = "Imię")]
        public string Name { get; set; }
        [Required, Display(Name = "Email"), EmailAddress]
        public string EmailAdress { get; set; }
        [Required, Display(Name="Twoja wiadomość")]
        public string Text { get; set; }
    }


}