using Dustin.Application.DTOs;
using Dustin.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dustin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator mediator;

        public BrandsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<BrandDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var brands = await mediator.Send(new GetBrandsQuery());
            return Ok(brands);
        }
    }
}