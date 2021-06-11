﻿using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    class ContactsVMtoContacts : Profile
    {
        public ContactsVMtoContacts()
        {
            CreateMap<ContactsViewModel, Contacts>();
        }
    }
}
