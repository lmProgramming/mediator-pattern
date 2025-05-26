using MediatorPattern.Models;
using MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get([FromQuery] string? firstName)
        {
            if (firstName == null)
            {
                return await mediator.Send(new GetPersonListQuery());
            }

            return await mediator.Send(new GetPersonListByNameQuery(firstName));
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PersonModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var p = await mediator.Send(new GetPersonByIdQuery(id));

            if (p == null)
            {
                return NotFound();
            }

            return Ok(p);
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
