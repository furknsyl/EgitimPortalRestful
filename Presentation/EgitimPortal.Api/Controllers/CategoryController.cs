using EgitimPortal.Application.Features.Categories.Command.CreateCategory;
using EgitimPortal.Application.Features.Products.Command.CreateCategory;
using EgitimPortal.Application.Features.Products.Command.DeleteCategory;
using EgitimPortal.Application.Features.Products.Command.UpdateCategory;
using EgitimPortal.Application.Features.Products.Query.GetAllCategory;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EgitimPortal.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllCategory()
        {
            var response = await _mediator.Send(new GetAllCategoryQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommandRequest command)
        {
            if (command == null)
            {
                return BadRequest();
            }

            await _mediator.Send(command);

            return Ok();
        }
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var command = new DeleteCategoryCommandRequest { Id = id };

            await _mediator.Send(command);

            return Ok();
        }
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] UpdateCategoryCommandRequest request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(request);

            return Ok();
        }
    }
}