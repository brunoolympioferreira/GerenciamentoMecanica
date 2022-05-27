using GerenciamentoMecanica.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public EmployeeFunctionEnum Function { get; set; }
        public decimal Salary { get; set; }
    }
}
