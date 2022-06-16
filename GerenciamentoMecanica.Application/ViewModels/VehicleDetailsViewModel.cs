using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class VehicleDetailsViewModel
    {
        public VehicleDetailsViewModel(int id, ManufacturerEnum manufacturer, string brand, DateTime yearOfManufacture, string licensePlate, int clientId)
        {
            Id = id;
            Manufacturer = manufacturer;
            Brand = brand;
            YearOfManufacture = yearOfManufacture;
            LicensePlate = licensePlate;
            ClientId = clientId;
        }

        public int Id { get; set; }
        public ManufacturerEnum Manufacturer { get; private set; }
        public string Brand { get; private set; }
        public DateTime YearOfManufacture { get; private set; }
        public string LicensePlate { get; private set; }
        public int ClientId { get; private set; }

        public virtual Client Client { get; set; }
        public virtual List<Service> Services { get; set; }
    }
}
