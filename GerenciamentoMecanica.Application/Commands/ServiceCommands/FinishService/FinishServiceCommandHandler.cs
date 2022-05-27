using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.FinishService
{
    public class FinishServiceCommandHandler : IRequestHandler<FinishServiceCommand, Unit>
    {
        private readonly IServiceRepository _serviceRepository;

        public FinishServiceCommandHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<Unit> Handle(FinishServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetByIdAsync(request.Id);

            service.FinishService(request.TotalCost);

            await _serviceRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
