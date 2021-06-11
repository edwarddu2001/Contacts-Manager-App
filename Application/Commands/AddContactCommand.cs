using Application.ViewModels;
using MediatR;

namespace Application.Commands
{
    public record AddContactCommand(ContactsViewModel contact) : IRequest<bool>;
}