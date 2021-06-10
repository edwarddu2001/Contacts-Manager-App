using Application.Repository;
using System.Collections.Generic;

namespace Application.QueryAndCommand
{
    public interface IRepository
    {
        public List<Contacts> GetContacts(string name, string phoneNumber);

        public List<Contacts> RemoveContacts(string name, string phoneNumber);
    }
}