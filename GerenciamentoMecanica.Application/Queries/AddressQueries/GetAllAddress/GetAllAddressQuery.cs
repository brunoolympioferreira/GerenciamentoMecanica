using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAllAddress
{
    public class GetAllAddressQuery : IRequest<List<AddressViewModel>>
    {
    }
}
