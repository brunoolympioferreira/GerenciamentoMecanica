using MediatR;

namespace GerenciamentoMecanica.Application.Commands.ServiceCommands.UpdateService
{
    public class UpdateServiceCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string ServiceDescription { get; private set; }
        public decimal TotalCost { get; private set; }
        public string UpdatedData { get; set; }
    }
}
