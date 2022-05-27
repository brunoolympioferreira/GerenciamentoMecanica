using MediatR;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.Resignation
{
    public class ResignationEmployeeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
