using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.VehicleCommands.CreateVehicle
{
    public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, int>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public CreateVehicleCommandHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public async Task<int> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
        {
            var vehicle = new Vehicle(
                request.Manufacturer,
                request.Brand,
                request.YearOfManufacture,
                request.LicensePlate,
                request.CliendId);

            await _vehicleRepository.AddVehicleAsync(vehicle);

            return vehicle.Id;
        }
    }
}
