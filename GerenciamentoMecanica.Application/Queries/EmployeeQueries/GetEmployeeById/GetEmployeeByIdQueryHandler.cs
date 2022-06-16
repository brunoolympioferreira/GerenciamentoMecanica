using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.EmployeeQueries.GetEmployeeById
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDetailsViewModel>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeDetailsViewModel> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeById(request.Id);

            if (employee == null) return null;

            var employeeViewModel = new EmployeeDetailsViewModel(
                employee.Id, employee.FullName, employee.BirthdayDate, employee.Age,
                employee.Cpf, employee.Rg, employee.CarteiraTrabalho, employee.Pis,
                employee.Reservista, employee.Salary, employee.AdmissionDate, employee.ResignationDate, employee.EmployeeStatus);

            return employeeViewModel;
        }
    }
}
