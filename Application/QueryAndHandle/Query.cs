using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueryAndHandle
{
    public class Query
    {
        // automapping between model/viewmodel here probably, by dependency between Application and WebUI
        public record Command() : IRequest<List<Contacts>>;

        public record Response(string Name, string PhoneNumber);
    }
}
