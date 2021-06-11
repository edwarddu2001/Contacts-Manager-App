using System.Collections.Generic;
using Application.Repositories;
using Domain.Models;

namespace Infrastructure
{
    public class StaticContactRepo : IRepository
    {
        private static List<Contacts> contactsList = new();

        public bool AddContacts(Contacts contact)
        {
            foreach (Contacts c in contactsList)
            {
                if (c.Name.Equals(contact.Name) && c.PhoneNum.Equals(contact.PhoneNum))
                {
                    return false;
                }
            }
            contactsList.Add(contact);
            return true;
        }

        public bool RemoveContacts(Contacts contact)
        {
            foreach (Contacts c in contactsList)
            {
                if (c.Name.Equals(contact.Name) && c.PhoneNum.Equals(contact.PhoneNum))
                {
                    contactsList.Remove(c);
                    return true;
                }
            }
            return false;
        }

        public List<Contacts> GetContacts()
        {
            return contactsList;
        }
    }
}