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
    public class ContactsHandler
    {
        // automapping between model/viewmodel here probably, by dependency between Application and WebUI
        public record Command(string Name, string PhoneNumber) : IRequest<Response>;

        public class Handler : IRequestHandler<Command, Response>
        {
            private Repository contacts;
            public Handler(Repository contacts)
            {
                this.contacts = contacts;
            }

            public Task<Response> Handle(Command request, CancellationToken cancellationToken)
            {
                // how to access name and phoneNumber to give to Repository?
                // error because it needs to return Task<Response> not List<Contacts>.
                // After changing that, TRequest and TResponse needs to be changed in IRequestHandler
                // Maybe make seperate files for cqrs?
                return Task.FromResult(contacts.AddContacts());
            }
        }

        public record Response(string Name, string PhoneNumber);
    }
}
