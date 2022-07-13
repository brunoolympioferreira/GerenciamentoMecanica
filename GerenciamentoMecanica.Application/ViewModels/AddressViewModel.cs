using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class AddressViewModel
    {
        public AddressViewModel(int id, string street, string number, string complement, string zipCode, string district, string city, StatesEnum state)
        {
            Id = id;
            Street = street;
            Number = number;
            Complement = complement;
            ZipCode = zipCode;
            District = district;
            City = city;
            State = state;
        }

        public int Id { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string ZipCode { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public StatesEnum State { get; private set; }
    }
}
