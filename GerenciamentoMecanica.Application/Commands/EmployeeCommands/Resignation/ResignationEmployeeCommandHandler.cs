using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.Resignation
{
    public class ResignationEmployeeCommandHandler : IRequestHandler<ResignationEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public ResignationEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Unit> Handle(ResignationEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeById(request.Id);

            employee.Resignation();

            await _employeeRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
