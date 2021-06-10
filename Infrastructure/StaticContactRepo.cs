using Application.Repositories;
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
        private List<Contacts> contactsList = new();

        // dummy GetContacts(), remove after handeler fixed
        public List<Contacts> AddContacts()
        {
            List<Contacts> contacts = new();
            return contacts;
        }

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