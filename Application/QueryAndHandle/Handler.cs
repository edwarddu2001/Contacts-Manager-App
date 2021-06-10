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
    public class Handler : IRequestHandler<Query, List<Contacts>>
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

        public Handler(IDataAcess )
        {

        }
        public Task<List<Contacts>> Handle(Query request, CancellationToken cancellationToken)
        {
            return 
        }
    }
}
