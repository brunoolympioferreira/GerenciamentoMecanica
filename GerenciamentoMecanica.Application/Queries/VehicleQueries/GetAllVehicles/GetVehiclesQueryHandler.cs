using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.VehicleQueries.GetAllVehicles
{
    public class GetVehiclesQueryHandler : IRequestHandler<GetVehiclesQuery, List<VehicleViewModel>>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public GetVehiclesQueryHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public async Task<List<VehicleViewModel>> Handle(GetVehiclesQuery request, CancellationToken cancellationToken)
        {
            var vehicles = await _vehicleRepository.GetAllVehiclesAsync();

            var vehiclesViewModel = vehicles
                .Select(v => new VehicleViewModel(v.Id, v.Manufacturer, v.Brand, v.ClientId))
                .ToList();

            return vehiclesViewModel;
        }
    }
}
