using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.VehicleQueries.GetVehicleById
{
    public class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQuery, VehicleDetailsViewModel>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public GetVehicleByIdQueryHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public async Task<VehicleDetailsViewModel> Handle(GetVehicleByIdQuery request, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(request.Id);

            if (vehicle == null) return null;

            var vehicleDetailsViewModel = new VehicleDetailsViewModel(
                vehicle.Id,vehicle.Manufacturer,vehicle.Brand,
                vehicle.YearOfManufacture,vehicle.LicensePlate,vehicle.ClientId
                );

            return vehicleDetailsViewModel;
        }
    }
}
