using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ClientCommands.UpdateClient
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, Unit>
    {
        private readonly IClientRepository _clientRepository;

        public UpdateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var updateClient = await _clientRepository.GetClientsByIdAsync(request.Id);

            updateClient.ClientUpdate(
                request.FullName,
                request.Email
                );

            await _clientRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
