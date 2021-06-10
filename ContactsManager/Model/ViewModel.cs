﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManager.Model
{
    public class ViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        // Phone instead of string?
        public string PhoneNumber { get; set; }
    }
}
