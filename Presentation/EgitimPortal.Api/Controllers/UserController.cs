using EgitimPortal.Application.Features.Auth.Command.UpdateUser;
using EgitimPortal.Application.Features.Auth.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EgitimPortal.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommandRequest request)
        {
            await _mediator.Send(request);
            return NoContent(); // Başarılı güncelleme için 204 No Content döner
        }
    }
}