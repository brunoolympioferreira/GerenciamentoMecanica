using MediatR;

namespace GerenciamentoMecanica.Application.Commands.EmployeeCommands.Admission
{
    public class AdmissionEmployeeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
