using MediatR;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.Vacation
{
    public class VacationEmployeeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int Days { get; set; }
    }
}
