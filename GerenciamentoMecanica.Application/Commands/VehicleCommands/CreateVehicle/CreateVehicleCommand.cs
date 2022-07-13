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
        public ManufacturerEnum Manufacturer { get; set; }
        public string Brand { get; set; }
        public string YearOfManufacture { get; set; }
        public string LicensePlate { get; set; }
        public int CliendId { get; set; }


    }
}
