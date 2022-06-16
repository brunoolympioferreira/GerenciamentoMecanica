using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;
using MediatR;

namespace GerenciamentoMecanica.Application.Commands.AddressCommands.CreateAddress
{
    public class CreateAddressCommand : IRequest<int>
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public StatesEnum State { get; set; }
        public int ClientId { get; set; }
    }
}
