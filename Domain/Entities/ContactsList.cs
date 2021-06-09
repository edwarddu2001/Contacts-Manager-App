using System;
using System.Collections.Generic;

namespace Domain
{
    public record Contact { string Name; int PhoneNum; }

    public static class ContactsList
    {
        public static List<Contact> Contacts { get; private set; } = new List<Contact>();
    }
}