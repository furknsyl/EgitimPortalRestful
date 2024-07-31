using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using EgitimPortal.Application.Features.Products.Query.GetAllPrdoucts;
using EgitimPortal.Application.Features.Products.Command.CreateProduct;
using EgitimPortal.Application.Features.Products.Command.DeleteProduct;
using EgitimPortal.Application.Features.Products.Command.UpdateProduct;
using Microsoft.AspNetCore.Authorization;

namespace EgitimPortal.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
                this.mediator = mediator;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllProducts() 
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

    }
}
