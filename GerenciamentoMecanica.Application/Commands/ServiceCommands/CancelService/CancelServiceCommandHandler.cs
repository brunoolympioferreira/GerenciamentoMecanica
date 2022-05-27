using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.CancelService
{
    public class CancelServiceCommandHandler : IRequestHandler<CancelServiceCommand, Unit>
    {
        private readonly IServiceRepository _serviceRepository;

        public CancelServiceCommandHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public async Task<Unit> Handle(CancelServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetByIdAsync(request.Id);

            service.CancelService();

            await _serviceRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
