using GerenciamentoMecanica.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string FullName { get; set; }
        public string BirthdayDate { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string CarteiraTabalho { get; set; }
        public string Pis { get; set; }
        public string Reservista { get; set; }
        public decimal Salary { get; set; }
        public EmployeeFunctionEnum Function { get; set; }
    }
}
