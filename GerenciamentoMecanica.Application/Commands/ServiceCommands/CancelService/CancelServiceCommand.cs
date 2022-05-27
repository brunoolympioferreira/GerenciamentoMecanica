﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.CancelService
{
    public class CancelServiceCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
