using GerenciamentoMecanica.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAddressById
{
    public class GetAddressByIdQuery : IRequest<AddressViewModel>
    {
        public GetAddressByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
