using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;
using System;
using System.Collections.Generic;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class ClientDetailsViewModel
    {
        public ClientDetailsViewModel(int id, string fullName, string email, string cpf, string street, string number, string zipCode, string district, List<Vehicle> vehicles)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Cpf = cpf;
            Street = street;
            Number = number;
            ZipCode = zipCode;
            District = district;
            Vehicles = vehicles;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string ZipCode { get; private set; }
        public string District { get; private set; }
        public List<Vehicle> Vehicles { get; set; }

        //public ManufacturerEnum Manufacturer { get; private set; }
        //public string Brand { get; private set; }
        //public DateTime YearOfManufacture { get; private set; }

    }
}
