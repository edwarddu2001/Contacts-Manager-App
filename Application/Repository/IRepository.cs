using System.Collections.Generic;

namespace Application.QueryAndCommand
{
    public interface IRepository
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }

        public List<Repository> GetContacts();
    }
}