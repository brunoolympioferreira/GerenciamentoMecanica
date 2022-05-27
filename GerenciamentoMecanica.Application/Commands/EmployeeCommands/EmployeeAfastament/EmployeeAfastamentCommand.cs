using MediatR;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.EmployeeAfastament
{
    public class EmployeeAfastamentCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int Days { get; set; }
    }
}
