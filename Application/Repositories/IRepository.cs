using Application.Repositories;
using System.Collections.Generic;
using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.Repositories
{
    public interface IRepository
    {
        public List<Contacts> AddContacts(Contacts contact);

        public List<Contacts> RemoveContacts(Contacts contact);
    }
}