using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace marlabskiranam.Models
{
    public class login
    {
        [DisplayName("Email ID")]
        [Required(ErrorMessage ="EmailID required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
    }
}