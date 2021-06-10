using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories

namespace Infrastructure
{
    public class StaticContactRepo : IRepository
    {
        private static List<Contacts> contactsList = new List<Contacts>();

        public List<Contacts> AddContacts(string name, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<Contacts> RemoveContacts(Contacts contact)
        {
            throw new NotImplementedException();
        }
    }
}