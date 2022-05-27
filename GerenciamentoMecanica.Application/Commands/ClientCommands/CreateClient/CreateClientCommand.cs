using MediatR;

namespace GerenciamentoMecanica.Application.Commands.ClientCommands.CreateClient
{
    public class CreateClientCommand : IRequest<int>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}
