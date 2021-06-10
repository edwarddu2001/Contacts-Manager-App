using Application.Repositories;
using System.Collections.Generic;
using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.Repositories
{
    public interface IRepository
    {
        public List<Contacts> AddContacts(string name, PhoneAttribute phoneNumber);

        public List<Contacts> RemoveContacts(Contacts contact);
    }
}