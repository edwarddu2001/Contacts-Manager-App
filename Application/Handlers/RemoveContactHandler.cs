using Application.Repositories;
using Application.Commands;
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
    public class RemoveContactHandler : IRequestHandler<AddContactCommand, List<ContactsViewModel>>
    {
        private readonly IRepository _data;
        private readonly IMapper _mapper;

        public RemoveContactHandler(IRepository data, ContactsViewModel contact, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task<List<ContactsViewModel>> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var addCommandSuccess = _data.RemoveContacts(_mapper.Map<Contacts>(request.contact));

            if (addCommandSuccess)
            {
                return Task.FromResult(new GetContactListQuery());
            }
            throw new ArgumentException("Contact is invalid!");
        }
    }
}