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

        public List<Contacts> AddContacts(Contacts contact)
        {
            contactsList.Add(contact);
            return contactsList;
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