using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Query
{
    public class GetContact
    {
        public record Command(int Id) : IRequest<Response>;

        public class Handler : IRequestHandler<Command, Response>
        {
            private Contacts contacts;
            public Handler(Contacts contacts)
            {
                this.contacts = contacts;
            }

            public Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                //return Task.FromResult(contacts)
            }
        }

        public record Response(int Id, string Name, string PhoneNumber);
    }
}
