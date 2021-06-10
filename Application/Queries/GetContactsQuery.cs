using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;
using Application.ViewModels;

namespace Application.Queries
{
    // automapping between model/viewmodel in application, by dependency between Application and WebUI
    public record GetContactsQuery() : IRequest<List<ContactsViewModel>>;
}