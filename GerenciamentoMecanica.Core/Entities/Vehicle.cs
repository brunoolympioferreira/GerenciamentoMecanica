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
        public Vehicle(int idClient, ManufacturerEnum manufacturer, string brand, DateTime yearOfManufacture, string licensePlate)
        {
            IdClient = idClient;
            Manufacturer = manufacturer;
            Brand = brand;
            YearOfManufacture = yearOfManufacture;
            LicensePlate = licensePlate;

            Services = new List<Service>();
        }

        public int IdClient { get; private set; }
        public Client Client { get; set; }
        public ManufacturerEnum Manufacturer { get; private set; }
        public string Brand { get; private set; }
        public DateTime YearOfManufacture { get; private set; }
        public string LicensePlate { get; private set; }
        public List<Service> Services { get; set; }
    }
}
