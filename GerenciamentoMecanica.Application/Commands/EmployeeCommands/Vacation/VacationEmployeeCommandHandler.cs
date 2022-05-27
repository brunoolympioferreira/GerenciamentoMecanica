using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.Vacation
{
    public class VacationEmployeeCommandHandler : IRequestHandler<VacationEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public VacationEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Unit> Handle(VacationEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeById(request.Id);
            var days = request.Days;

            employee.Vacation(days);

            await _employeeRepository.SaveChangesAsync();

            return Unit.Value;

        }
    }
}
