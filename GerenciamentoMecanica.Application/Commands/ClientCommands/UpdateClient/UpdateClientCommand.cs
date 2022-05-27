using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ClientCommands.UpdateClient
{
    public class UpdateClientCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
