using MediatR;
using System.Collections.Generic;
using Application.ViewModels;

namespace Application.Queries
{
    // automapping between model/viewmodel in application, by dependency between Application and WebUI
    public record GetContactsQuery() : IRequest<List<ContactsViewModel>>;
}