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
using AutoMapper;

namespace Application.Handlers
{
    public class AddContactHandler : IRequestHandler<AddContactCommand, bool>
    {
        private readonly IRepository _data;
        private readonly IMapper _mapper;

        public AddContactHandler(IRepository data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task<bool> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddContacts(_mapper.Map<Contacts>(request.contact)));
        }
    }
}