using MediatR;

namespace GerenciamentoMecanica.Application.Commands.VehicleCommands.DeleteVehicle
{
    public class DeleteVehicleCommand : IRequest<Unit>
    {
        public DeleteVehicleCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
