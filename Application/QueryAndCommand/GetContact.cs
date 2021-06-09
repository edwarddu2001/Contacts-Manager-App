using Application.QueryAndCommand;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueryAndCommand
{
    public class GetContact
    {
        public record Command(string Name, string PhoneNumber) : IRequest<Response>;

        public class Handler : IRequestHandler<Command, Response>
        {
            private Repository contacts;
            public Handler(Repository contacts)
            {
                //this.contacts = contacts;
            }

            public Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                //return Task.FromResult(contacts)
            }
        }

        public record Response(string Name, string PhoneNumber);
    }
}
