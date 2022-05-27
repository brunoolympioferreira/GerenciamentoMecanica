using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.CreateService
{
    public class CreateServiceCommand : IRequest<int>
    {
        public string ServiceDescription { get; set; }
        public int IdClient { get; set; }
        public int IdVehicle { get; set; }
    }
}
