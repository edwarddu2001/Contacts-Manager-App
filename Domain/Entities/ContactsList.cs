using System;
using System.Collections.Generic;

namespace Domain
{
    public record Contact { string Name; int PhoneNum; int ID; }

    public static class ContactsList
    {
        public static List<Contact> Contacts { get; private set; } = new List<Contact>();
    }
}