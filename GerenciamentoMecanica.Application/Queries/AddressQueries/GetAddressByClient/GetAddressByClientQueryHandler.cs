using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAddressByClient
{
    public class GetAddressByClientQueryHandler : IRequestHandler<GetAddressByClientQuery, AddressViewModel>
    {
        private readonly IAddressRepository _addressRepository;

        public GetAddressByClientQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<AddressViewModel> Handle(GetAddressByClientQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressByIdEmployeeAsync(request.IdClient);

            if (address == null) return null;

            var addressViewModel = new AddressViewModel(
                address.Id,
                address.Street,
                address.Number,
                address.Complement,
                address.ZipCode,
                address.District,
                address.City,
                address.State
                );

            return addressViewModel;
        }
    }
}
