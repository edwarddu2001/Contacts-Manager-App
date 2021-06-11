using Application.Repositories;
using Application.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;
using AutoMapper;

namespace Application.Handlers
{
    public class RemoveContactHandler : IRequestHandler<RemoveContactCommand, bool>
    {
        private readonly IRepository _data;
        private readonly IMapper _mapper;

        public RemoveContactHandler(IRepository data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task<bool> Handle(RemoveContactCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.RemoveContacts(_mapper.Map<Contacts>(request.contact)));
        }
    }
}
