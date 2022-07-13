using GerenciamentoMecanica.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Core.DTOs
{
    public class ClientVehiclesDTO
    {
        public ClientVehiclesDTO(ManufacturerEnum manufacturer, string brand, string yearOfManufacture, string licensePlate)
        {
            Manufacturer = manufacturer;
            Brand = brand;
            YearOfManufacture = yearOfManufacture;
            LicensePlate = licensePlate;
        }

        public ManufacturerEnum Manufacturer { get; private set; }
        public string Brand { get; private set; }
        public string YearOfManufacture { get; private set; }
        public string LicensePlate { get; private set; }
    }
}
