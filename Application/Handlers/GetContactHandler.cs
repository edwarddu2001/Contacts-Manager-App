using Application.Queries;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class GetContactHandler : IRequestHandler<Query, List<ContactsViewModel>>
    {
        public GetContactHandler()
        {

        }

        public Task<List<ContactsViewModel>> Handle(Query request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
