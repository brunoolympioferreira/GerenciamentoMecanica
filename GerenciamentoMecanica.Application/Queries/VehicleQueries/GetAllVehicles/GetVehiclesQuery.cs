using GerenciamentoMecanica.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.VehicleQueries.GetAllVehicles
{
    public class GetVehiclesQuery : IRequest<List<VehicleViewModel>>
    {
    }
}
