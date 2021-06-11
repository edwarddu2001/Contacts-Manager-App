using Application.ViewModels;
using MediatR;

namespace Application.Commands
{
    public record RemoveContactCommand(ContactsViewModel contact) : IRequest<bool>;
}