using Application.ViewModels;
using AutoMapper;
using Domain.Models;

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