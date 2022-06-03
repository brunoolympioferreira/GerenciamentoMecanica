using GerenciamentoMecanica.Core.Enums;

namespace GerenciamentoMecanica.Core.DTOs
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string ZipCode { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public StatesEnum State { get; private set; }
    }
}
