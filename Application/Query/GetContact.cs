using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Query
{
    public static class GetContact
    {
        public record Command(int Id) : IRequest<Contacts>;

        public class Handler : IRequestHandler<Command, Response>
        {
            public Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }

        public record Response(int Id, string Name, string PhoneNumber);
    }
}
