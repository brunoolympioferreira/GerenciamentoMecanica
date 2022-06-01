using MediatR;

namespace GerenciamentoMecanica.Application.Commands.VehicleCommands.DeleteVehicle
{
    public class DeleteVehicleCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
