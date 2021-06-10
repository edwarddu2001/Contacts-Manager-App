using Application.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.QueryAndCommand
{
    public class Repository : IRepository
    {
        // dummy GetContacts(), remove after handeler fixed
        public List<Contacts> GetContacts()
        {
            List<Contacts> contacts = new();
            return contacts;
        }

        public List<Contacts> GetContacts(string name, string phoneNumber)
        {
            if(!(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber)))
            {
                // add to list of contacts somehow
            }
            List<Contacts> contacts = new();
            return contacts;
        }

        public List<Contacts> RemoveContacts(string name, string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}