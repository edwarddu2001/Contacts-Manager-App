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

namespace Application.Handlers
{
    public class AddContactHandler : IRequestHandler<AddContactCommand, List<Contacts>>
    {
        private readonly IRepository _data;
        private readonly Contacts _contact;

        public AddContactHandler(IRepository data, Contacts contact)
        {
            _data = data;
            _contact = contact;
        }

        public Task<List<Contacts>> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {

            return Task.FromResult(_data.AddContacts(_contact));
        }
    }
}
