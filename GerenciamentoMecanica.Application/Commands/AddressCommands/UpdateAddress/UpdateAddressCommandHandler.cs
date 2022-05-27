using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.AddressCommands.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, Unit>
    {
        private readonly IAddressRepository _addressRepository;

        public UpdateAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetByIdAsync(request.Id);

            address.UpdateAddress(
                request.Street,
                request.Number,
                request.Complement,
                request.ZipCode,
                request.District,
                request.City,
                request.State
                );

            await _addressRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
