using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Models;

namespace Infrastructure
{
    public class StaticContactRepo : IRepository
    {
        private static List<Contacts> contactsList = new();

        public List<Contacts> AddContacts(string name, PhoneAttribute phoneNumber)
        {
            if (!string.IsNullOrEmpty(name))
            {
                contactsList.Add(new Contacts()
                {
                    Name = name,
                    PhoneNum = phoneNumber
                });
                return contactsList;
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