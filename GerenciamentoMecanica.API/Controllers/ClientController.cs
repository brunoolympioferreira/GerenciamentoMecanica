using GerenciamentoMecanica.Application.Commands.ClientCommands.CreateClient;
using GerenciamentoMecanica.Application.Commands.ClientCommands.UpdateClient;
using GerenciamentoMecanica.Application.Queries.ClientQueries.GetAllClients;
using GerenciamentoMecanica.Application.Queries.ClientQueries.GetClientsById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.API.Controllers
{
    [Route("api/client")]
    //[ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllClientsQuery = new GetAllClientsQuery();

            var clients = await _mediator.Send(getAllClientsQuery);

            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetClientByIdQuery(id);

            var client = await _mediator.Send(query);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClientCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateClientCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
