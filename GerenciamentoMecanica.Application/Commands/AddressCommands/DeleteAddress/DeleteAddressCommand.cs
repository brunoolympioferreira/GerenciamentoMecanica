using GerenciamentoMecanica.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.AddressCommands.DeleteAddress
{
    public class DeleteAddressCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
