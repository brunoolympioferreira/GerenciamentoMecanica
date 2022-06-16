using GerenciamentoMecanica.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.VehicleQueries.GetVehicleById
{
    public class GetVehicleByIdQuery : IRequest<VehicleDetailsViewModel>
    {
        public GetVehicleByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
