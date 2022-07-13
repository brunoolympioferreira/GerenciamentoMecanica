using GerenciamentoMecanica.Core.DTOs;
using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;
using System;
using System.Collections.Generic;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class ClientDetailsViewModel
    {
        public ClientDetailsViewModel(int id, string fullName, string email, string cpf, string street, string number, string complement, string zipCode, string district, string city, StatesEnum state, IEnumerable<ClientVehiclesDTO> vehicles)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Cpf = cpf;
            Street = street;
            Number = number;
            Complement = complement;
            ZipCode = zipCode;
            District = district;
            City = city;
            State = state;
            Vehicles = vehicles;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string ZipCode { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public StatesEnum State { get; private set; }

        public IEnumerable<ClientVehiclesDTO> Vehicles { get; set; }
    }
}
