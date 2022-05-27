using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.EmployeeAfastament
{
    public class EmployeeAfastamentCommandHandler : IRequestHandler<EmployeeAfastamentCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeAfastamentCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Unit> Handle(EmployeeAfastamentCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeById(request.Id);
            var days = request.Days;

            employee.EmployeeAfastament(days);

            await _employeeRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
