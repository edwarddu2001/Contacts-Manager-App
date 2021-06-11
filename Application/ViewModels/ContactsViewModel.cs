﻿using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class ContactsViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNum { get; set; }
    }
}