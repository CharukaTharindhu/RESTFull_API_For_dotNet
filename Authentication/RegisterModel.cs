﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace boilerPlate_for_dotNetCore_RESTFull_Web_API.Authentication
{
    public class RegisterModel
    {
        [Required (ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Passsword { get; set; }
    }
}
