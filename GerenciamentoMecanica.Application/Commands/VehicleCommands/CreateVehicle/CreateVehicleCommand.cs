using GerenciamentoMecanica.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Commands.VehicleCommands.CreateVehicle
{
    public class CreateVehicleCommand : IRequest<int>
    {
        public ManufacturerEnum Manufacturer { get; private set; }
        public string Brand { get; private set; }
        public DateTime YearOfManufacture { get; private set; }
        public string LicensePlate { get; private set; }
        public int CliendId { get; set; }


    }
}
