﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgedBook.Models
{
    public class UserLogin
    {
        [Display(Name ="E-mail ID")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Email ID required")]
        public string EmailID { get; set; }
        
        [Required(AllowEmptyStrings =false, ErrorMessage ="Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}