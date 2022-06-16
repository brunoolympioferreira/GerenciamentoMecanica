using GerenciamentoMecanica.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace GerenciamentoMecanica.Application.Queries.ClientQueries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<List<ClientViewModel>>
    {
    }
}
