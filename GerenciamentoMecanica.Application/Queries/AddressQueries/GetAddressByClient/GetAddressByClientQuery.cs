using GerenciamentoMecanica.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAddressByClient
{
    public class GetAddressByClientQuery : IRequest<AddressViewModel>
    {
        public GetAddressByClientQuery(int idClient)
        {
            IdClient = idClient;
        }

        public int IdClient { get; private set; }
    }
}
