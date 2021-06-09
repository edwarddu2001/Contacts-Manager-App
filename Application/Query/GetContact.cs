using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query
{
    public class GetContact
    {
        // Query / Command
        public record Query(string Name, int phoneNum) : IRequest<Contact>;

        //Handler


        // Response
    }
}
