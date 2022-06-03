using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAddressById
{
    public class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQuery,AddressViewModel>
    {
        private readonly IAddressRepository _addressRepository;

        public GetAddressByIdQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<AddressViewModel> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetByIdAsync(request.Id);

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
