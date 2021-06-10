using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.QueryAndHandle
{
    public class Handler : IRequestHandler<Query, List<Contacts>>
    {
        private readonly IRepository _data;
        private readonly Contacts _contact;
        public Handler(IRepository data, Contacts contact)
        {
            _data = data;
            _contact = contact;
        }
        public Task<List<Contacts>> Handle(Query request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddContacts(_contact));
        }
    }
}
