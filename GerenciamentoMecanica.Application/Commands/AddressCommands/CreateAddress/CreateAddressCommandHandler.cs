using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.AddressCommands.CreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
    {
        private readonly IAddressRepository _addressRepository;

        public CreateAddressCommandHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = new Address(
                request.ClientId,
                request.Street,
                request.Number,
                request.Complement,
                request.ZipCode,
                request.District,
                request.City,
                request.State
                );

            await _addressRepository.AddAddressAsync(address);

            return address.Id;
        }
    }
}
