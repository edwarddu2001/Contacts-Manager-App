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
            List<Contacts> listOfContacts = _data.GetContacts(_mapper.Map<Contacts>(request.contact));
            List<ContactsViewModel> contactsViewModel = new();
            for(int i = 0; i < listOfContacts.Count; i++)
            {
                listOfContacts[i].Name = contactsViewModel[i].Name;
                listOfContacts[i].PhoneNum = contactsViewModel[i].PhoneNum;
            }
            return Task.FromResult(contactsViewModel);
        }
    }
}
