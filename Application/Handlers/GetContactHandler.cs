using Application.Queries;
using Application.Repositories;
using Application.ViewModels;
using AutoMapper;
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
        private readonly IRepository _data;
        private readonly IMapper _mapper;
        private readonly ContactsViewModel _contact;

        public GetContactHandler(IRepository data, ContactsViewModel contact, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
            _contact = contact;
        }

        public Task<List<ContactsViewModel>> Handle(Query request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetContacts(_mapper.Map<Contacts>(request.contact));
        }
    }
}
