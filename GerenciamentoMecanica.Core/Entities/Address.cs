using GerenciamentoMecanica.Core.Enums;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Address : BaseEntity
    {
        public Address(int clientId,string street, string number, string complement, string zipCode, string district, string city, StatesEnum state)
        {
            ClientId = clientId;
            Street = street;
            Number = number;
            Complement = complement;
            ZipCode = zipCode;
            District = district;
            City = city;
            State = state;
        }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string ZipCode { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public StatesEnum State { get; private set; }
        public int ClientId { get; private set; }
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }

        public void UpdateAddress(string street, string number, string complement, string zipCode, string district, string city, StatesEnum state)
        {
            Street = street;
            Number= number;
            Complement = complement;
            ZipCode = zipCode;
            District = district;
            City = city;
            State = state;
        }
    }
}
