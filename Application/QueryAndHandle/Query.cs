using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.QueryAndHandle
{
    // automapping between model/viewmodel in application, by dependency between Application and WebUI
    public record Query() : IRequest<List<Contacts>>;
}
