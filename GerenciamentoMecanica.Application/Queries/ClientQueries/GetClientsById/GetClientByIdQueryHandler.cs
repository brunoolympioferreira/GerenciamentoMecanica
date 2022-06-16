using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.ClientQueries.GetClientsById
{
    public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, ClientDetailsViewModel>
    {
        private readonly IClientRepository _clientRepository;

        public GetClientByIdQueryHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<ClientDetailsViewModel> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetClientsByIdAsync(request.Id);

            if (client == null) return null;

            var clientViewModel = new ClientDetailsViewModel(
                client.Id,client.FullName,client.Email,client.Cpf,
                client.Address.Street,client.Address.Number,client.Address.ZipCode,client.Address.District,
                client.Vehicles
                );

            return clientViewModel;
        }
    }
}
