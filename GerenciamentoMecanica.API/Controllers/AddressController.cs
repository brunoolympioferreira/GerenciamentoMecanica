using GerenciamentoMecanica.Application.Commands.AddressCommands.CreateAddress;
using GerenciamentoMecanica.Application.Commands.AddressCommands.UpdateAddress;
using GerenciamentoMecanica.Application.Queries.AddressQueries.GetAddressById;
using GerenciamentoMecanica.Application.Queries.AddressQueries.GetAllAddress;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.API.Controllers
{
    [Route("api/address")]
    //[ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getAllAddressQuery = new GetAllAddressQuery();

            var adddresses = await _mediator.Send(getAllAddressQuery);

            return Ok(adddresses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetAddressByIdQuery(id);

            var address = await _mediator.Send(query);

            if (address == null)
            {
                return NotFound();
            }

            return Ok(address);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAddressCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("id")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateAddressCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
