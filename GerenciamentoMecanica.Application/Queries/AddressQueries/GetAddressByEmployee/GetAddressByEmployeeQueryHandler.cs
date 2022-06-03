using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAddressByEmployee
{
    public class GetAddressByEmployeeQueryHandler : IRequestHandler<GetAddressByEmployeeQuery, AddressViewModel>
    {
        private readonly IAddressRepository _addressRepository;

        public GetAddressByEmployeeQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task<AddressViewModel> Handle(GetAddressByEmployeeQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressByIdEmployeeAsync(request.IdEmployee);

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
