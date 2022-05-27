using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.FinishService
{
    public class FinishServiceCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public decimal TotalCost { get; set; }
    }
}
