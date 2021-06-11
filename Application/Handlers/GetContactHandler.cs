using Application.Queries;
using Application.Repositories;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class GetContactHandler : IRequestHandler<GetContactsQuery, List<ContactsViewModel>>
    {
        private readonly IRepository _data;
        private readonly IMapper _mapper;

        public GetContactHandler(IRepository data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task<List<ContactsViewModel>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            List<Contacts> listofContacts = _data.GetContacts();
            return Task.FromResult(_mapper.Map<List<ContactsViewModel>>(listofContacts));
        }

    }
}
