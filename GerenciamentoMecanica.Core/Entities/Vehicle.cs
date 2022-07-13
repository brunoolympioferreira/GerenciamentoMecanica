using GerenciamentoMecanica.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Vehicle : BaseEntity
    {
        public Vehicle(ManufacturerEnum manufacturer, string brand, string yearOfManufacture, string licensePlate)
        {
            Manufacturer = manufacturer;
            Brand = brand;
            YearOfManufacture = yearOfManufacture;
            LicensePlate = licensePlate;
        }

        public Vehicle(ManufacturerEnum manufacturer, string brand, string yearOfManufacture, string licensePlate, int clientId)
        {
            Manufacturer = manufacturer;
            Brand = brand;
            YearOfManufacture = yearOfManufacture;
            LicensePlate = licensePlate;
            ClientId = clientId;

            Services = new List<Service>();
        }

        public ManufacturerEnum Manufacturer { get; private set; }
        public string Brand { get; private set; }
        public string YearOfManufacture { get; private set; }
        public string LicensePlate { get; private set; }

        public int ClientId { get; private set; }
        public virtual Client Client { get; set; }
        public virtual List<Service> Services { get; set; }
    }
}
