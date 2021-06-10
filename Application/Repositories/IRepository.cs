using Application.Repositories;
using System.Collections.Generic;

namespace Application.Repositories
{
    public interface IRepository
    {
        public List<Contacts> AddContacts(string name, string phoneNumber);

        public List<Contacts> RemoveContacts(Contacts contact);
    }
}