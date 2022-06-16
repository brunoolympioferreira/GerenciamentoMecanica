using GerenciamentoMecanica.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.ClientQueries.GetClientsById
{
    public class GetClientByIdQuery : IRequest<ClientDetailsViewModel>
    {
        public GetClientByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
