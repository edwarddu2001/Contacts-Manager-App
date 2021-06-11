using System.Collections.Generic;
using Domain.Models;

namespace Application.Repositories
{
    public interface IRepository
    {
        public bool AddContacts(Contacts contact);

        public bool RemoveContacts(Contacts contact);

        public List<Contacts> GetContacts();

    }
}