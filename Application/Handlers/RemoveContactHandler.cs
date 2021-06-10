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
    public class RemoveContactHandler : IRequestHandler<AddContactCommand, bool>
    {
        private readonly IRepository _data;
        private readonly IMapper _mapper;

        public RemoveContactHandler(IRepository data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task<bool> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.RemoveContacts(_mapper.Map<Contacts>(request.contact)));
        }
    }
}
