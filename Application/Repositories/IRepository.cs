using Application.Repositories;
using System.Collections.Generic;
using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.Repositories
{
    public interface IRepository
    {
        public bool AddContacts(Contacts contact);

        public bool RemoveContacts(Contacts contact);
    }
}