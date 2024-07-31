using EgitimPortal.Domain.Entities;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EgitimPortal.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Notification>>> GetNotifications()
        {
            var notifications = await _unitOfWork.GetReadRepository<Notification>().GetAllAsync();
            return Ok(notifications);
        }
    }
}