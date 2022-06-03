using GerenciamentoMecanica.Application.ViewModels;
using MediatR;

namespace GerenciamentoMecanica.Application.Queries.AddressQueries.GetAddressByEmployee
{
    public class GetAddressByEmployeeQuery : IRequest<AddressViewModel>
    {
        public GetAddressByEmployeeQuery(int idEmployee)
        {
            IdEmployee = idEmployee;
        }

        public int IdEmployee { get; private set; }
    }
}
