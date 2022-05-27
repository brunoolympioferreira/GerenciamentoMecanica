using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, int>
    {
        private readonly IServiceRepository _serviceRepository;

        public CreateServiceCommandHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public async Task<int> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = new Service(
                request.ServiceDescription,
                request.IdClient,
                request.IdVehicle
                );

            await _serviceRepository.AddServiceAsync(service);

            return service.Id;
        }
    }
}
