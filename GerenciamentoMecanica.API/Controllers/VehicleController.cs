using GerenciamentoMecanica.Application.Commands.VehicleCommands.CreateVehicle;
using GerenciamentoMecanica.Application.Commands.VehicleCommands.DeleteVehicle;
using GerenciamentoMecanica.Application.Queries.VehicleQueries.GetAllVehicles;
using GerenciamentoMecanica.Application.Queries.VehicleQueries.GetVehicleById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.API.Controllers
{
    [Route("api/vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllVehicles = new GetVehiclesQuery();

            var vehicles = await _mediator.Send(getAllVehicles);

            return Ok(vehicles);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetVehicleByIdQuery(id);

            var vechicle = await _mediator.Send(query);

            if (vechicle == null)
            {
                return NotFound();
            }

            return Ok(vechicle);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateVehicleCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = new GetVehicleByIdQuery(id);

            var vechicle = await _mediator.Send(query);

            if (vechicle == null)
            {
                return BadRequest();
            }

            var command = new DeleteVehicleCommand(id);

            await _mediator.Send(command);

            return NoContent();

        }
    }
}
