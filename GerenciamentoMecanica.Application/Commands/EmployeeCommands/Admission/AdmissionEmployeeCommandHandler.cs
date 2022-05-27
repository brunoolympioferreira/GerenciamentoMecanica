using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.Admission
{
    public class AdmissionEmployeeCommandHandler : IRequestHandler<AdmissionEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public AdmissionEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Unit> Handle(AdmissionEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeById(request.Id);

            employee.Admission();

            await _employeeRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
