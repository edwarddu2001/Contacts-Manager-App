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
            if (!string.IsNullOrEmpty(name))
            {
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    contactsList.Add(new Contacts()
                    {
                        Name = name,
                        PhoneNumber = phoneNumber
                    });
                    return contactsList;
                }
                throw new ArgumentException("Phone Number is Empty!");
            }
            throw new ArgumentException("Name is Empty!");
        }

        public List<Contacts> RemoveContacts(Contacts contact)
        {
            if (contactsList.Remove(contact))
            {
                return contactsList;
            }
            throw new ArgumentException("Contact does not exist!");
        }
    }
}