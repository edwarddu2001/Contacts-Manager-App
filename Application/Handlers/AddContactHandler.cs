using Application.Repositories;
using Application.Commands;
using Application.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Application.ViewModels;

namespace Application.Handlers
{
    public class AddContactHandler : IRequestHandler<AddContactCommand, List<ContactsViewModel>>
    {
        private readonly IRepository _data;
        private readonly IMapper _mapper;

        public AddContactHandler(IRepository data, ContactsViewModel contact, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task<List<ContactsViewModel>> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var addCommandSuccess = _data.AddContacts(_mapper.Map<Contacts>(request.contact));

            if (addCommandSuccess)
            {
                return Task.FromResult(GetContactsQuery());
            }
            throw new ArgumentException("Contact is invalid!");
        }
    }
}