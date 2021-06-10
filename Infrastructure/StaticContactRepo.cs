using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class StaticContactRepo : IRepository
    {
        private static List<Contacts> contactsList = new();

        public List<Contacts> AddContacts(string name, string phoneNumber)
        {
            if (!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber)))
            {
                contactsList.Add(new Contacts()
                {
                    Name = name,
                    PhoneNumber = phoneNumber
                });
            }
            return contactsList;
        }

        public List<Contacts> RemoveContacts(Contacts contact)
        {
            contactsList.Remove(contact);
            return contactsList;
        }
    }
}