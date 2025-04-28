using Dustin.Application.Commands.Product;
using Dustin.Application.DTOs;
using Dustin.Application.Queries.Product;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dustin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IValidator<CreateProductDTO> createValidator;
        private readonly IValidator<UpdateProductDTO> updateValidator;

        public ProductsController(IMediator mediator, IValidator<CreateProductDTO> createValidator, IValidator<UpdateProductDTO> updateValidator)
        {
            this.mediator = mediator;
            this.createValidator = createValidator;
            this.updateValidator = updateValidator;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProductDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var products = await mediator.Send(new GetProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var product = await mediator.Send(new GetProductsByIdQuery(id));
            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateProductDTO createProductDTO)
        {
            ValidationResult result = await createValidator.ValidateAsync(createProductDTO);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return BadRequest(result);
            }

            var product = await mediator.Send(new SaveProductCommand(createProductDTO));
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] UpdateProductDTO updateProductDTO)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var product = await mediator.Send(new GetProductsByIdQuery(id));

            if (product is null)
            {
                return NotFound();
            }

            ValidationResult result = await updateValidator.ValidateAsync(updateProductDTO);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return BadRequest(result);
            }

            await mediator.Send(new UpdateProductCommand(updateProductDTO));
            return NoContent();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest();
            }

            var product = await mediator.Send(new GetProductsByIdQuery(id));

            if (product is null)
            {
                return NotFound();
            }

            await mediator.Send(new DeleteProductCommand(id));
            return NoContent();
        }
    }
}