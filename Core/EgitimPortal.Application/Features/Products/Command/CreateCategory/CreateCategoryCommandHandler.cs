using EgitimPortal.Application.Bases;
using EgitimPortal.Application.Features.Products.Command.CreateCategory;
using EgitimPortal.Application.Interfaces.AutoMapper;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandHandler : BaseHandler, IRequestHandler<CreateCategoryCommandRequest, Unit>
    {

        public CreateCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
            : base(mapper, unitOfWork, httpContextAccessor)
        {

        }

        public async Task<Unit> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Category> categories = await unitOfWork.GetReadRepository<Category>().GetAllAsync();

            Category category = new Category
            {
                Name = request.Name
                // Diğer özellikler
            };

            await unitOfWork.GetWriteRepository<Category>().AddAsync(category);
            await unitOfWork.SaveAsync();
            var notification = new Notification
            {
                Message = "Yeni kategori oluşturuldu.",
                CreatedDate = DateTime.UtcNow
            };

            // Bildirimi veritabanına ekle
            await unitOfWork.GetWriteRepository<Notification>().AddAsync(notification);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}