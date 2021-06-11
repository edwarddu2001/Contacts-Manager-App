using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class ContactsProfile : Profile
    {
        public ContactsProfile()
        {
            CreateMap<Contacts, ContactsViewModel>();
            CreateMap<ContactsViewModel, Contacts>();
        }
    }
}