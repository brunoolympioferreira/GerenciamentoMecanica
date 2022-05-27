using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.UpdateService
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand, Unit>
    {
        private readonly IServiceRepository _serviceRepository;

        public UpdateServiceCommandHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public async Task<Unit> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetByIdAsync(request.Id);

            service.UpdateService(request.ServiceDescription, request.TotalCost);

            await _serviceRepository.SaveChangesAsync();

            return Unit.Value;

        }
    }
}
