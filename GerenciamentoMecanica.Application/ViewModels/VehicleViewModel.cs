using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class VehicleViewModel
    {
        public VehicleViewModel(int id, ManufacturerEnum manufacturer, string brand, int clientId)
        {
            Id = id;
            Manufacturer = manufacturer;
            Brand = brand;
            ClientId = clientId;
        }

        public int Id { get; private set; }
        public ManufacturerEnum Manufacturer { get; private set; }
        public string Brand { get; private set; }
        public int ClientId { get; private set; }
    }
}
