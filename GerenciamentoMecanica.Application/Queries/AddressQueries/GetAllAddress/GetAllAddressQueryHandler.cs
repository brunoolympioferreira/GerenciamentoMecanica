using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.DTOs;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAllAddress
{
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQuery, List<AddressViewModel>>
    {
        private readonly IAddressRepository _addressRepository;

        public GetAllAddressQueryHandler(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<AddressViewModel>> Handle(GetAllAddressQuery request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAllAddressAsync();

            var adddressViewModel = address
                .Select(a => new AddressViewModel(
                    a.Id,a.Street,a.Number,a.Complement,a.ZipCode,a.District,a.City,a.State))
                .ToList();

            return adddressViewModel;
        }
    }
}
