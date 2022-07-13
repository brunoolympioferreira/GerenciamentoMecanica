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
        public VehicleDetailsViewModel(int id, ManufacturerEnum manufacturer, string brand, string yearOfManufacture, string licensePlate, int clientId, string clientName)
        {
            Id = id;
            Manufacturer = manufacturer;
            Brand = brand;
            YearOfManufacture = yearOfManufacture;
            LicensePlate = licensePlate;
            ClientId = clientId;
            ClientName = clientName;
        }

        public int Id { get; set; }
        public ManufacturerEnum Manufacturer { get; private set; }
        public string Brand { get; private set; }
        public string YearOfManufacture { get; private set; }
        public string LicensePlate { get; private set; }
        public int ClientId { get; private set; }
        public string ClientName { get; set; }

    }
}
