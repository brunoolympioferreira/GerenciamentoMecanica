using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.DTOs;
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
                client.Id, client.FullName, client.Email, client.Cpf,
                client.Address.Street, client.Address.Number, client.Address.Complement, client.Address.ZipCode, client.Address.District,
                client.Address.City, client.Address.State,
                client.Vehicles.Select(v => new ClientVehiclesDTO(v.Manufacturer, v.Brand, v.YearOfManufacture, v.LicensePlate)).ToList());

            return clientViewModel;
        }
    }
}
