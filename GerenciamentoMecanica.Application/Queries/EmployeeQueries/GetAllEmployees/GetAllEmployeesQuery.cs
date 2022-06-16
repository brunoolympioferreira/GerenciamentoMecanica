using GerenciamentoMecanica.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace GerenciamentoMecanica.Application.Queries.EmployeeQueries.GetAllEmployees
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeViewModel>>
    {
    }
}
